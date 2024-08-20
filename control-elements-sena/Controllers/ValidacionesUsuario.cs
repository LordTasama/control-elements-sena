using FluentValidation;
using System.Linq;

namespace control_elements_sena
{
    public class ValidacionesUsuario : AbstractValidator<UsuarioModel>
    {
        private readonly string[] CommonPasswords = new string[]
        {
        "123456", "password", "contraseña","123456789", "12345678", "12345", "1234567", "qwerty", "abc123"
        };
        public ValidacionesUsuario()
        {
            // Definición de reglas de validación
            RuleFor(x => x.Nombres)
               .NotEmpty().WithMessage("Los nombres son obligatorios").WithErrorCode("empty");
            RuleFor(x => x.Apellidos)
               .NotEmpty().WithMessage("Los apellidos son obligatorios").WithErrorCode("empty");
            RuleFor(x => x.Identificacion)
               .NotEmpty().WithMessage("La identificación es obligatoria").WithErrorCode("empty")
               .Matches(@"^\d+$").WithMessage("La identificación no es valida.")
               .Matches(@"^\S*$").WithMessage("La identificación no debe contener espacios.");
            RuleFor(x => x.Correo)
                .NotEmpty().WithMessage("El correo es obligatorio.").WithErrorCode("empty")
                .EmailAddress().WithMessage("El correo no es válido.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("La contraseña es obligatoria.").WithErrorCode("empty").When(x => x.PasswordRequired)
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.").When(x => x.PasswordRequired)
                .Matches(@"[A-Z]").WithMessage("La contraseña debe contener al menos una letra mayúscula.").When(x => x.PasswordRequired)
                .Matches(@"[a-z]").WithMessage("La contraseña debe contener al menos una letra minúscula.").When(x => x.PasswordRequired)
                .Matches(@"^\S*$").WithMessage("La contraseña no puede tener espacios.").When(x => x.PasswordRequired)
                .Must(password => !CommonPasswords.Contains(password)).WithMessage("La contraseña es demasiado común.").When(x => x.PasswordRequired)
                .Must((user, password) => !password.Contains(user.Correo.Split('@')[0])).WithMessage("La contraseña no puede contener su correo o parte de él.").When(x => x.PasswordRequired);
        }
    }
}


using System.Linq;
using FluentValidation;

namespace control_elements_sena
{
    public class Validaciones : AbstractValidator<Usuario>
    {
        private readonly string[] CommonPasswords = new string[]
        {
        "123456", "password", "123456789", "12345678", "12345", "1234567", "qwerty", "abc123"
        };
        public Validaciones()
        {
            // Definición de reglas de validación
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("El correo es obligatorio.")
                .EmailAddress().WithMessage("El correo no es válido.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("La contraseña es obligatoria.")
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.")
                .Matches(@"[A-Z]").WithMessage("La contraseña debe contener al menos una letra mayúscula.")
                .Matches(@"[a-z]").WithMessage("La contraseña debe contener al menos una letra minúscula.")
                .Matches(@"[0-9]").WithMessage("La contraseña debe contener al menos un número.")
                .Matches(@"[\W]").WithMessage("La contraseña debe contener al menos un carácter especial.")
                .Must(password => !CommonPasswords.Contains(password)).WithMessage("La contraseña es demasiado común.")
                .Must((user, password) => !password.Contains(user.Email.Split('@')[0])).WithMessage("La contraseña no puede contener su correo o parte de él.");
            ;
        }
    }
}


using FluentValidation;
using System.Linq;

namespace control_elements_sena
{
    public class ValidacionesEntrada : AbstractValidator<EntradasModel>
    {
        public ValidacionesEntrada()
        {
            // Definición de reglas de validación
            RuleFor(x => x.Id_Propietario)
          .NotEmpty().WithMessage("La identificación del propietario es obligatoria").WithErrorCode("empty").When(x => x.registroValidate)
          .Matches(@"^\d+$").WithMessage("La identificación del propietario no es valida.").When(x => x.registroValidate)
          .Matches(@"^\S*$").WithMessage("La identificación del propietario no debe contener espacios.").When(x => x.registroValidate);
            RuleFor(x => x.Nombres_Propietario)
               .NotEmpty().WithMessage("Los nombres del propietario son obligatorios.").When(x => x.registroValidate).WithErrorCode("empty");
            RuleFor(x => x.Marca)
               .NotEmpty().WithMessage("La marca del elemento es obligatoria.").When(x=> x.elementValidate).WithErrorCode("empty");
            RuleFor(x => x.Serie)
                .NotEmpty().WithMessage("La serie del elemento es obligatioria.").When(x => x.elementValidate).WithErrorCode("empty");

        }
    }
}


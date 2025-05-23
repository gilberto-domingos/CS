using DevLabs.Api.Dtos;
using MediatR;

namespace DevLabs.Api.Commands.Autor
{
    public class EditarAutorCommand : IRequest<Entities.Autor>
    {
        public AutorEditarDto AutorEditarDto { get; set; }

        public EditarAutorCommand(AutorEditarDto autorEditarDto)
        {
            AutorEditarDto = autorEditarDto;
        }
    }
}

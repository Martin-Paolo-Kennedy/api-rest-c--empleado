using AutoMapper;
using Gestion_Farmacia_martin.DTOs;
using Gestion_Farmacia_martin.Models;
using System.Globalization;

namespace Gestion_Farmacia_martin.Utilidades
{
    public class AuyoMapperProfile:Profile
    {
        public AuyoMapperProfile()
        {
            #region Departamento
            CreateMap<Departamento, DepartamentoDTO>().ReverseMap();
            #endregion

            #region Empleado
            CreateMap<Empleado, EmpleadoDTO>()
                .ForMember(destino =>
                destino.NomDepartamento,
                opt => opt.MapFrom(origen => origen.IdDepartamentoNavigation.Nombre)
                )
                .ForMember(destino =>
                destino.FechaContratacion,
                opt => opt.MapFrom(origen => origen.FechaContratacion.Value.ToString("dd/MM/yyyy"))
            );
            CreateMap<EmpleadoDTO, Empleado>()
                .ForMember(destino =>
                destino.IdDepartamentoNavigation,
                opt => opt.Ignore()
                )
                .ForMember(destino =>
                destino.FechaContratacion,
                opt => opt.MapFrom(origen => DateTime.ParseExact(origen.FechaContratacion, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                );
            #endregion
        }
    }
}

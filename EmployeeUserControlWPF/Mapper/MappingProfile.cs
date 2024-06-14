using AutoMapper;
using EmployeeUserControlWPF.Model;
using EmployeeUserControlWPF.Model.ResponseModel;
using System.Linq;

namespace EmployeeUserControlWPF.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeModel, EmployeeGridDTO>()
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DOB, opt => opt.MapFrom(src => src.DOB))
                 .ForMember(dest => dest.Departments, opt => opt.MapFrom(src => src.Departments != null
                ? string.Join(", ", src.Departments.Select(c => c.Department.Name)) : string.Empty))
                .ForMember(dest => dest.Salary, opt => opt.MapFrom(src => src.Salary));
        }
    }
}

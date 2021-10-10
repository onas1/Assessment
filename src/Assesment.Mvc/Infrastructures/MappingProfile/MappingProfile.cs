using AutoMapper;
using HiresHoldingsAssesment.Models;
using HiresHoldingsAssesment.ViewModels;

namespace HiresHoldingsAssesment.Infrascture.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AppUser, AdminViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }
    }
}

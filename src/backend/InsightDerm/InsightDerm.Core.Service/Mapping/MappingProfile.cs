using AutoMapper;
using InsightDerm.Core.Data.Domain.Model;
using InsightDerm.Core.Dto;

namespace InsightDerm.Core.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityDto>();

            CreateMap<Antecedent, AntecedentDto>();

            CreateMap<CurrentIllness, CurrentIllnessDto>();

            CreateMap<Doctor, DoctorDto>();

            CreateMap<MedicalCenter, MedicalCenterDto>();

            CreateMap<MedicalHistory, MedicalHistoryDto>();

            CreateMap<PatientAntecedent, PatientAntecedentDto>();

            CreateMap<Patient, PatientDto>();

            CreateMap<PhysicalExam, PhysicalExamDto>();

            CreateMap<Reason, ReasonDto>();

            CreateMap<TreatmentPlan, TreatmentPlanDto>();

            CreateMap<Cie10, Cie10Dto>();

            CreateMap<Diagnostic, DiagnosticDto>();
        }
    }
}

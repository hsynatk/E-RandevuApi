using Application.Dtos.AppointmentDtos;
using Application.Interfaces;
using Application.Services.Abstract;
using AutoMapper;
using Domain;

namespace Application.Services.Concrete
{
    public class AppointmentServices : IAppointmentServices
    {
        private readonly IGenericServices<Appointment> _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentServices(IGenericServices<Appointment> appointmentRepository, IMapper mapper)
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }

        public async Task AddAppointment(CreateAppointmentDto dto)
        {
            var appointment = _mapper.Map<Appointment>(dto);
            await _appointmentRepository.AddAsync(appointment);

        }

        public async Task DeleteAppointment(int id)
        {
            var appointment =await _appointmentRepository.GetByIdAsync(id);
            await _appointmentRepository.DeleteAsync(appointment);


        }

        public async Task<List<ResultAppointmentDto>> GetAllAppointment()
        {
           var appointments =await  _appointmentRepository.GetAllAsync();
            var result = _mapper.Map<List<ResultAppointmentDto>>(appointments);
            return result;
        }

        public async Task<ResultAppointmentDto> GetByIdAppointment(int id)
        {

            var appointment = await _appointmentRepository.GetByIdAsync(id);
            var result = _mapper.Map<ResultAppointmentDto>(appointment);
            return result;
        }

        public async Task UpdateAppointment(UpdateAppointmentDto dto)
        {
            var appointment = await _appointmentRepository.GetByIdAsync(dto.Id);
            var newAppointment = _mapper.Map(dto, appointment);
            await _appointmentRepository.UpdateAsync(newAppointment);
        }
    }
}

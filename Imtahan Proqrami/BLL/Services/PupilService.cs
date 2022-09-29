using AutoMapper;
using Imtahan_Proqrami.BLL.Services.IServices;
using Imtahan_Proqrami.DAL.Repositories.IRepositories;
using Imtahan_Proqrami.Entities;
using Imtahan_Proqrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.BLL.Services
{
    public class PupilService: IPupilService
    {
        private readonly IPupilRepository _pupilRepository;
        private readonly IMapper _mapper;
        public PupilService(IPupilRepository  pupilRepository, IMapper mapper)
        {
            _pupilRepository = pupilRepository;
            _mapper = mapper;
        }
        public async Task Add(PupilToAddDTO  pupilToAddDTO)
        {
            Pupil pupil = _mapper.Map<Pupil>(pupilToAddDTO);
            await _pupilRepository.Add(pupil);
        }

        public async Task Delete(int pupilId)
        {
            await _pupilRepository.Delete(pupilId);
        }

        public async Task<List<PupilToListDTO>> Get()
        {
            List<Pupil> pupil = await _pupilRepository.Get();
            return _mapper.Map<List<PupilToListDTO>>(pupil);
        }

        public async Task<PupilToUpdateDTO> GetId(int pupilId)
        {
            Pupil pupil = await _pupilRepository.GetId(pupilId);
            return _mapper.Map<PupilToUpdateDTO>(pupil);
        }

        public async Task Update(PupilToUpdateDTO  pupilToUpdateDTO)
        {
            Pupil pupil = _mapper.Map<Pupil>(pupilToUpdateDTO);
            await _pupilRepository.Update(pupil);
        }
    }
}

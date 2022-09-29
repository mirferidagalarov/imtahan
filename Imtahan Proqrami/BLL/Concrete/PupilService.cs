using AutoMapper;
using Imtahan_Proqrami.BLL.Abstract;
using Imtahan_Proqrami.DAL.Abstract;
using Imtahan_Proqrami.Entities;
using Imtahan_Proqrami.Models;
using Imtahan_Proqrami.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.BLL.Concrete
{
    public class PupilService : IPupilService
    {
        private readonly IUnitOfWorks _unitOfWork;
        private readonly IMapper _mapper;
        public PupilService(IUnitOfWorks  unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;              
            _mapper = mapper;
        }
        public async Task Add(PupilToAddDTO pupilToAddDTO)
        {
            Pupil pupil = _mapper.Map<Pupil>(pupilToAddDTO);
            await _unitOfWork.PupilRepository.Add(pupil);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int pupilId)
        {
            await _unitOfWork.PupilRepository.Delete(pupilId);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<PupilToListDTO>> Get()
        {
            List<Pupil> pupil = await _unitOfWork.PupilRepository.Get();
            return _mapper.Map<List<PupilToListDTO>>(pupil);
        }

        public async Task<PupilToUpdateDTO> GetId(int pupilId)
        {
            Pupil pupil = await _unitOfWork.PupilRepository.GetId(pupilId);
            return _mapper.Map<PupilToUpdateDTO>(pupil);
        }

        public async Task Update(PupilToUpdateDTO pupilToUpdateDTO)
        {
            Pupil pupil = _mapper.Map<Pupil>(pupilToUpdateDTO);
            await _unitOfWork.PupilRepository.Update(pupil);
            await _unitOfWork.CommitAsync();
        }
    }
}

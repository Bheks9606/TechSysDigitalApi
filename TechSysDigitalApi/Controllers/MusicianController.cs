using AutoMapper;
using DataInterface.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechSysDigitalApi.Contracts;
using TechSysDigitalApi.Data;
using TechSysDigitalApi.Models;

namespace TechSysDigitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly IMusicianRepository musicianRepository;
        private readonly IMapper mapper;

        public MusicianController(IMusicianRepository musicianRepository, IMapper mapper)
        {
            this.musicianRepository = musicianRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMusicians()
        {
            try
            {
                var musician = mapper.Map<List<MusicianDto>>(await musicianRepository.GetAllAsync());
                return Ok(musician);
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMusician(int id)
        {
            try
            {
                var musician = mapper.Map<MusicianDto>(await musicianRepository.GetAsync(id));

                if (musician == null)
                {
                    return NotFound();
                }

                return Ok(musician);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

        [HttpPost]
        public async Task<IActionResult> CreateMusician([FromBody] MusicianDto musicianDto)
        {
            try
            {
                var musician = new Musician
                { 
                    Name= musicianDto.Name, 
                    DateModified = null,
                    DateCreated = DateTime.Now,
                    StageName= musicianDto.StageName,
                    Bio = musicianDto.Bio,
                    Genre= musicianDto.Genre,
                };

                await musicianRepository.AddAsync(musician);
                return Ok(musician);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMusician(int id, [FromBody] MusicianDto musicianDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var existingMusician = await musicianRepository.GetAsync(id);

                if(existingMusician == null)
                {
                    return NotFound();
                }

                existingMusician.Name = musicianDto.Name;
                existingMusician.StageName = musicianDto.StageName;
                existingMusician.Bio = musicianDto.Bio;
                existingMusician.Genre = musicianDto.Genre;
                existingMusician.DateModified = DateTime.Now;

                await musicianRepository.UpdateAsync(existingMusician);   

                return NoContent();


            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusician(int id)
        {
            try 
            {
                var musician = await musicianRepository.GetAsync(id);

                if (musician != null)
                {
                    await musicianRepository.DeleteAsync(id);
                    return Ok(musician);
                }

                return NotFound();
            }
            catch(Exception ex) 
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }


    }
}

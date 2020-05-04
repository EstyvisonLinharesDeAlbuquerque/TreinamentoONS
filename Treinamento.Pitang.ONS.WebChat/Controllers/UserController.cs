using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using Pitang.Treinamento.ONS.Services;
using Treinamento.Pitang.ONS.Services;
using Treinamento.Pitang.ONS.Views;

namespace Treinamento.Pitang.ONS.WebChat.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IEnumerable<User> _users;
        private IUserService _userService;
        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<UserDto>>> Get([FromServices] DataContext contexto)
        {
            _users = await _userService.GetAllUsers();
            List<UserDto> usersDto = new List<UserDto>();
            foreach (User user in _users)
            {
                usersDto.Add(_mapper.Map<User, UserDto>(user));
            }
            return usersDto;
        }

        
        [HttpGet]
        [Route("{id:int}")]
        //[Authorize(Roles = "usuario")]
        public async Task<ActionResult<UserDto>> GetById(
            int id,
            [FromServices] DataContext context)
        {
           
            var user = await _userService.GetUser(id);
            
            UserDto userDto = _mapper.Map<User, UserDto>(user);

            if (userDto == null)
                return NotFound(new { message = "Usuário não encontrado" });

            return userDto;
        }
        
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<UserDto>> Post([FromBody] UserDto modelDto,
            [FromServices] DataContext context)
        {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        User user = _mapper.Map<UserDto, User>(modelDto);

        _userService.Add(user);
        await context.SaveChangesAsync();
        var newUserDto = _mapper.Map<User, UserDto>(await _userService.GetUser(user.Id));
        return newUserDto;
        }

        [HttpPut]
        [Route("{id:int}")]
        //[Authorize(Roles = "usuario")]
        public async Task<ActionResult<UserDto>> Put(int id, [FromBody] UserDto modelDto)
        {
            
            User user = _mapper.Map<UserDto, User>(modelDto);
            if (id != user.Id)
            {
                return NotFound(new { message = "Usuário não encontrado!" });
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
           var newUserDto =  _mapper.Map<User, UserDto>(await _userService.Update(user));
            
            return newUserDto;
        }

        [HttpDelete]
        [Route("{id:int}")]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            
        var user = await _userService.GetUser(id);
        if (user == null)
            return NotFound(new { message = "Usuário não encontrado" });
            user.IsDeleted = true;

            _userService.Delete(user);
                
        return Ok();

        }
    }
}

          
            


            
             



          
        


           
               
                

            


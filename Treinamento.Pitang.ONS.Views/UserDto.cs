using System;
using System.Collections.Generic;

namespace Treinamento.Pitang.ONS.Views
{
    public class UserDto
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public List<ContactDto> ContactDtos { get; set; }
        public List<MessageDto> MessageDtos { get; set; }
        public List <StoryDto> StoryDtos { get; set; }




    }
}

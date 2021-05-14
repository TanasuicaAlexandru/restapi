using API.DTO_s;
using API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target 
            CreateMap<Command, CommandReadDto>();

            //From -> To
            CreateMap<CommandCreateDto, Command>();

            //From -> To
            CreateMap<CommandUpdateDto, Command>();

            //From -> To
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}

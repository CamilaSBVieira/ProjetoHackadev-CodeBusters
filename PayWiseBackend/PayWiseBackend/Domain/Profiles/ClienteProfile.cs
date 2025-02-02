﻿using AutoMapper;
using PayWiseBackend.Domain.DTOs;
using PayWiseBackend.Domain.Models;

namespace PayWiseBackend.Domain.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile() : base()
        {
            CreateMap<CreateClientDTO, Cliente>();        
        }
    }
}

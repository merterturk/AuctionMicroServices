﻿using AutoMapper;
using Ordering.Application.Commands.OrderCreate;
using Ordering.Application.Response;
using Ordering.Domain.Entities;

namespace Ordering.Application.Mapper
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderCreateCommand>().ReverseMap();
            CreateMap<Order, OrderResponse>().ReverseMap();
        }
    }
}

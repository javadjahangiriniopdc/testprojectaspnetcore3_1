using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using testprojectaspnetcore3_1.Data;
using testprojectaspnetcore3_1.Models;

namespace testprojectaspnetcore3_1.Mapping
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<Kala, DetailsKalaViewModel>().ReverseMap();
            CreateMap<Kala, CreateKalaViewModel>().ReverseMap();
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
            CreateMap<OrderApp, OrderAppViewModel>().ReverseMap();
        }
    }
}

﻿using AutoMapper;
using Talabat.APIs.DTOs;
using Talabat.Core.Entities;

namespace Talabat.APIs.Helpers
{
	public class ProductPictureURLRResolver : IValueResolver<Product, ProductToReturnDTO, string>
	{
		private readonly IConfiguration _configuration;

		public ProductPictureURLRResolver(IConfiguration configuration)
        {
			_configuration = configuration;
		}
        public string Resolve(Product source, ProductToReturnDTO destination, string destMember, ResolutionContext context)
		{
			if(!string.IsNullOrEmpty(source.PictureUrl))
			{
				return $"{_configuration["APIBaseURL"]}/{source.PictureUrl}";
			}
			return string.Empty ;
		}
	}
}

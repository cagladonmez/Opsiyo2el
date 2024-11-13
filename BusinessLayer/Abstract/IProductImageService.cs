﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IProductImageService : IGenericService<ProductImage>
	{
		List<ProductImage> GetImagesById(int id);
	}

   
}

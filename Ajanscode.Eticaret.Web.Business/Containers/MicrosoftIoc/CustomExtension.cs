using Ajanscode.Eticaret.Web.Business.Concreate;
using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Business.ValidationRules.FluentValidation;
using Ajanscode.Eticaret.Web.Dal.Concreate.EntitiyFrameworkCore;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Dtos.Concreate;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Business.Containers.MicrosoftIoc
{
   public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection Service)
        {
            #region DAL KATMANI
            Service.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            Service.AddScoped<IIlceDal, EfIlceRepostory>();
            Service.AddScoped<ISehirDal, EfSehirRepostory>();
            Service.AddScoped<ISemtDal, EfSemtRepostory>();
            Service.AddScoped<IUlkeDal, EfUlkeRepostory>();
            Service.AddScoped<IKategoriDal, EfKategoriRepository>();
            #endregion
            #region BUSİNESS KATMANI
            Service.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            Service.AddScoped<IIlceService, IlceManager>();
            Service.AddScoped<ISehirService, SehirManager>();
            Service.AddScoped<ISemtService, SemtManager>();
            Service.AddScoped<IUlkeService, UlkeManager>();
            Service.AddScoped<IKategoriService, KategoriManager>();
            #endregion
            Service.AddTransient<IValidator<UlkeAddDto>, UlkeAddValidator>();
            Service.AddTransient<IValidator<KategoriAddDto>, KategoriAddValidator>();
        }
    }
}

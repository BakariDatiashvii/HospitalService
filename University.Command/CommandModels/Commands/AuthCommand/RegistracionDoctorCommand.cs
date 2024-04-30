using HospitalService.Command.CommandModels.AuthCommandModels;
using HospitalService.Domain.Contracts;
using HospitalService.Domain.Entities.Categories;
using HospitalService.Domain.Entities.CategoryDoctors;
using HospitalService.Domain.Entities.Doctors;
using HospitalService.Domain.Entities.Users;
using HospitalService.Domain.Service;
using HospitalService.Infrastructure;
using HospitalService.Shared.Enumes;
using HospitalService.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace HospitalService.Command.CommandModels.Commands.AuthCommand
{
    public class RegistracionDoctorCommand : CommandBase
    {
        public readonly RegistrationDoctorCommandModel _model;
        public RegistracionDoctorCommand(RepositoryProvider repositoryProvider,
        IAuthorizedUserService authorizedUserService, RegistrationDoctorCommandModel model)
            : base(repositoryProvider, authorizedUserService)
        {
            _model = model;

        }

        public async override Task<Result> HandleAsync()
        {
            var similarUser = await _repositoryProvider.Users.GetQueryable()
                .FirstOrDefaultAsync(x => x.Email == _model.Email);

            if (similarUser != null)
            {
                return Result.Error("მსგავსი მეილით მომხმარებელი უკვე არსებობს");
            }


            byte[] passwordHash;
            byte[] passwordSalt;

            AuthService authService = new AuthService();
            authService.CreatePasswordHash(_model.Password, out passwordHash, out passwordSalt);

            byte[] POTO = null;
            byte[] CV = null;
            using (var memoryStreamm = new MemoryStream())
            {
                await _model.photo.CopyToAsync(memoryStreamm);


                POTO = memoryStreamm.ToArray();





            }

            using (var memoryStreamm1 = new MemoryStream())
            {
                await _model.photo.CopyToAsync(memoryStreamm1);


                CV = memoryStreamm1.ToArray();





            }

            var User = new User()
            {
                Email = _model.Email,
                Role = Role.Doctor,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FirstName = _model.FirstName,
                LastName = _model.LastName,
                PrivateNumber = _model.PrivateNumber,


                Doctor = new Doctor()
                {
                    photo = POTO,
                    cv = CV,



                },




            };

           


            List<string> categoryDoctorName = new List<string> ()
            {
             "\"ანდროლოგი\"",
             "\"ანესთეზიოლოგი\"",
             "\"კარდიოლოგი\"",
             "\"ჯოსმეტოლოგი\"",
             "\"ლაბორანტი\"",
             "\"ოჯახისექიმი\"",
              "\"პედიატრი\"",
              "\"ტოქსიკოლოგი\"",
              "\"ტრანსფუზილოგი\"",
              "\"გინეკოლოგი\"",
              "\"დერმატოლოგი\"",
              "\"ენდოკრინოლოგი\"",
              "\"გასტროენტეროლოგი\"",
              "\"თერაპევტი\""

            };

           

            if (_model.categoryname.Count > 0)
            {
                for (int i = 0; i < _model.categoryname.Count; i++)
                {
                    
                    for (int y = i +1; y < _model.categoryname.Count; y++)
                    {
                        if (_model.categoryname[i] == _model.categoryname[y])
                        {
                            return Result.Error("pizdec EMTXVEVA");
                        }
                    }
                }
            }


            var T = 0;

            foreach (var x in _model.categoryname) 
            {
                T = 0;
                foreach (var y in categoryDoctorName)
                {
                   if (x == y)
                    {
                        T++;
                    }
                }

                if (T == 0)
                {
                    return Result.Error("PIZDECI");
                }
            }


            _repositoryProvider.Users.Create(User);
            _repositoryProvider.Doctors.Create(User.Doctor);
    




            foreach (var x in _model.categoryname)
            {
                var z =  _repositoryProvider.Categorys.GetQueryable().FirstOrDefault(z => z.Name == x.Trim());
                var doctorCategory = new CategoryDoctor();
                if (z != null)
                {
                    doctorCategory.CategoryId = z.Id;
                    doctorCategory.Category = z;

                    

                    doctorCategory.DoctorId = User.Doctor.Id;
                    _repositoryProvider.Categorys.Update(z);
                  

                  

                    _repositoryProvider.CategoryDoctors.Create(doctorCategory);
                 


                }
                else
                {
                    var category = new Category();
                    


                    category.Name = x;

                    _repositoryProvider.Categorys.Create(category);

                    doctorCategory.DoctorId = User.Doctor.Id;
                    doctorCategory.CategoryId = category.Id;
                    doctorCategory.Category = category;
                    doctorCategory.Doctor = User.Doctor;

                    _repositoryProvider.CategoryDoctors.Create(doctorCategory);

                }

               


            }
            







            var token = _authorizedUserService.GenerateToken(User);

         
            _repositoryProvider.UnitOfWork.SaveChange();

            return Result.Success((object)token);



        }
    }
}

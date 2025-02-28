﻿using System.Net.Http.Headers;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementations
{
    public class EspecialidadHelper : IEspecialidadHelper
    {

        IServiceRepository _repository;

        public EspecialidadHelper(IServiceRepository serviceRepository)
        {
            _repository = serviceRepository;
        }

        public string Token { get; set; }

        private void SetAuthorizationHeader()
        {
            _repository.Client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Token);
        }

        public EspecialidadViewModel AddEspecialidad(EspecialidadViewModel EspecialidadViewModel)
        {
            SetAuthorizationHeader();
            EspecialidadViewModel especialidad = new EspecialidadViewModel();
            HttpResponseMessage responseMessage = _repository.PostResponse("api/especialidad", EspecialidadViewModel);
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                especialidad = JsonConvert.DeserializeObject<EspecialidadViewModel>(content);
            }
            return especialidad;
        }

        public void DeleteEspecialidad(int id)
        {
            SetAuthorizationHeader();
            HttpResponseMessage responseMessage = _repository.DeleteResponse("api/especialidad/" + id.ToString());
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
            }
        }

        public EspecialidadViewModel EditEspecialidad(EspecialidadViewModel EspecialidadViewModel)
        {
            SetAuthorizationHeader();
            EspecialidadViewModel especialidad = new EspecialidadViewModel();
            HttpResponseMessage responseMessage = _repository.PutResponse("api/especialidad", EspecialidadViewModel);
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                especialidad = JsonConvert.DeserializeObject<EspecialidadViewModel>(content);
            }
            return especialidad;
        }

        public List<EspecialidadViewModel> GetAll()
        {
            SetAuthorizationHeader();
            List<EspecialidadViewModel> lista = new List<EspecialidadViewModel>();
            HttpResponseMessage responseMessage = _repository.GetResponse("api/Especialidad");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<EspecialidadViewModel>>(content);
            }
            return lista;
        }

        public EspecialidadViewModel GetById(int id)
        {
            SetAuthorizationHeader();
            EspecialidadViewModel Especialidad = new EspecialidadViewModel();
            HttpResponseMessage responseMessage = _repository.GetResponse("api/Especialidad/" + id.ToString());
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                Especialidad = JsonConvert.DeserializeObject<EspecialidadViewModel>(content);
            }
            return Especialidad;
        }
    }
}

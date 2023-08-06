﻿using QuizMaster.Apli.Aplication.EntityServices;
using QuizMaster.Dominio.Model.Entities;
using QuizMaster.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ApplicationController
{
    public class RespuestasController
    {
        private RespuestasServices servicesRespuestas;
        private PreguntasServices servicesPreguntas;

        public RespuestasController() 
        {
            servicesRespuestas = new RespuestasServices();
            servicesPreguntas = new PreguntasServices();
        }
        public bool InsertarRespuestas(RespuestasViewModel NuevaRespuesta)
        {
            Respuestas nuevoRegistro = new Respuestas();
            try
            {
                nuevoRegistro.IDPregunta = NuevaRespuesta.IDPregunta;
                nuevoRegistro.Respuesta = NuevaRespuesta.Respuesta;
                nuevoRegistro.EsCorrecta = NuevaRespuesta.EsCorrecta;
                servicesRespuestas.InsertarRespuestas(nuevoRegistro);
                return true;
            }
            catch (Exception ex) 
            {
                throw new Exception("Error al insertar Respuestas: " + ex.Message);
            }
        }
   
        /*here**/

        public IEnumerable<RespuestasViewModel> ListarRespuestas()
        {
            var listaRespuestas = servicesRespuestas.ListarRespuestas();
            List<RespuestasViewModel> resultadoEnvio = new List<RespuestasViewModel>();
            try
            {
                foreach (Respuestas item in listaRespuestas)
                {
                    resultadoEnvio.Add(new RespuestasViewModel
                    {
                        IDPregunta = item.IDPregunta,
                        Respuesta = item.Respuesta,
                        EsCorrecta = item.EsCorrecta,
                    });
                }
                return resultadoEnvio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Pregunta y Respuesta Usuarios: " + ex.Message);

            }
        }


    }




}

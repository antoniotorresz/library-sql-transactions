using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Modelo;

namespace Datos
{
    public class Firebase
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0UeDcrgrOHNs6sLHTiCrdjKrCwkHq6DCNzx9tJjQ",
            BasePath = "https://fir-androidudemy.firebaseio.com/"
        };

        public void Start() {
            client = new FireSharp.FirebaseClient(this.config);

            if (client != null) Console.WriteLine("Connected to firebase!");
        }

        public async void InsertLibro(Libro l, int id)
        {
            
            var libro = new Libro
            {
                idLibro = id,
                titulo = l.titulo,
                editorial = l.editorial,
                fechaPublicacion = l.fechaPublicacion,
                imageUrl = l.imageUrl, 
                isbn = l.isbn, 
                pais = l.pais
            };
            Start();
            SetResponse response = await client.SetTaskAsync("Libros/" + l.titulo, libro);
            Libro result = response.ResultAs<Libro>();
        }
    }
}

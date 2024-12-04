namespace ApiCrud.Estudantes
{

    using Dados;

    public static class EstudantesEndPoints
    {

        public static void addEndPointsEstudantes(this WebApplication app)
        {

            var rotasEstudantes = app.MapGroup("estudante");

            app.MapPost("", (AddEstudanteRequest request, AppDbContext context) =>
            {

                var novoEstudante = new Estudante(request.Nome);

            });

            

        }

    }
}

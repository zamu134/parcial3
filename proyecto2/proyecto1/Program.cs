using System;

class Program
{
    static void Main()
    {
        using (var db = new Context())
        {
            var estudiante1 = new Notas { Nombre = "Estudiante1", NotaParciales = 80, NotaLaboratorios = 90 };
            var estudiante2 = new Notas { Nombre = "Estudiante2", NotaParciales = 75, NotaLaboratorios = 85 };

            db.Notas.AddRange(estudiante1, estudiante2);
            db.SaveChanges();
        }

        using (var db = new Context())
        {

            var estudiantes = db.Notas.ToList();

            Console.WriteLine("ID   \tNombre    \tNota Parciales    \tNota Laboratorios     \tNota Final");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"{estudiante.Id}\t{estudiante.Nombre}        \t{estudiante.NotaParciales}        \t{estudiante.NotaLaboratorios}         \t{estudiante.NotaFinal}");
            }
        }
    }
}


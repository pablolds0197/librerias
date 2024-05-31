﻿using System;
using System.Collections.Generic;

namespace CRUDjpmaEF.Models;

public partial class Libro
{
    public string Isbn { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? NombreAutor { get; set; }

    public DateOnly? Publicacion { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public int? CodigoCategoria { get; set; }

    public int? NitEditorial { get; set; }

    public virtual Categoria? CodigoCategoriaNavigation { get; set; }

    public virtual Editoriale? NitEditorialNavigation { get; set; }
}

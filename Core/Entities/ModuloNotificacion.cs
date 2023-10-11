using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class ModuloNotificacion
{
    [Required]
    public string AsuntoNotificacion { get; set; }
    [Required]
    public string TextoNotificacion { get; set; }
    [Required]
    public DateOnly FechaCreacion { get; set; }
    [Required]
    public DateOnly FechaModificación { get; set; }
    public int IdRadicadosFk { get; set; }
    public Radicados Radicados { get; set; }
    public int IdFormatosFk { get; set; }
    public ICollection<Formato> Formatos { get; set; }
    public int IdTipoRequerimientoFk { get; set; }
    public TipoRequerimiento TipoRequerimientos { get; set; }
    public int IdEstadoNotificacionFk { get; set; }
    public EstadoNotificacion EstadoNotificaciones { get; set; }
    public int IdTipoNotificacionesFk { get; set; }
    public TipoNotificacion TipoNotificaciones { get; set; }
    public int IdHiloRespuestaFk { get; set; }
    public HiloRespuestaNotificacion HiloRespuestaNotificaciones { get; set; }
    
}
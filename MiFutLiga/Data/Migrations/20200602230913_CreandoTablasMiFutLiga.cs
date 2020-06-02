using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiFutLiga.Data.Migrations
{
    public partial class CreandoTablasMiFutLiga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "usrfut7");

            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    idAdministrador = table.Column<int>(nullable: false),
                    Login = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Contrasenia = table.Column<string>(unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.idAdministrador);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    idCategoria = table.Column<int>(nullable: false),
                    NombreCategoria = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Abierta = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Colores",
                columns: table => new
                {
                    idColor = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colores", x => x.idColor);
                });

            migrationBuilder.CreateTable(
                name: "DiasSemana",
                columns: table => new
                {
                    idDia = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiasSemana", x => x.idDia);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    idGrupo = table.Column<int>(nullable: false),
                    NombreGrupo = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    NumEquipos = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.idGrupo);
                });

            migrationBuilder.CreateTable(
                name: "Horas",
                columns: table => new
                {
                    idHora = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horas", x => x.idHora);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    idModulo = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Activo = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.idModulo);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    idParticipante = table.Column<int>(nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    Domicilio = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    Telefono = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Contrasenia = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.idParticipante);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    idPermiso = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.idPermiso);
                });

            migrationBuilder.CreateTable(
                name: "Temas",
                columns: table => new
                {
                    idTema = table.Column<int>(nullable: false),
                    Anio = table.Column<int>(nullable: false),
                    Mes = table.Column<int>(nullable: false),
                    Dia = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temas", x => x.idTema);
                });

            migrationBuilder.CreateTable(
                name: "Temporadas",
                columns: table => new
                {
                    idTemporada = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temporadas", x => x.idTemporada);
                });

            migrationBuilder.CreateTable(
                name: "TiposJugador",
                columns: table => new
                {
                    idTipoJugador = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposJugador", x => x.idTipoJugador);
                });

            migrationBuilder.CreateTable(
                name: "TiposSancion",
                columns: table => new
                {
                    idTipoSancion = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Valor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposSancion", x => x.idTipoSancion);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false),
                    Login = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Activo = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Llista",
                schema: "usrfut7",
                columns: table => new
                {
                    idLLista = table.Column<int>(nullable: false),
                    idJuego = table.Column<int>(nullable: false),
                    idEquipo = table.Column<int>(nullable: false),
                    idJugador = table.Column<int>(nullable: false),
                    Asistio = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llista", x => x.idLLista);
                });

            migrationBuilder.CreateTable(
                name: "LUsuarios",
                schema: "usrfut7",
                columns: table => new
                {
                    idLUsuario = table.Column<int>(nullable: false),
                    Login = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Rol = table.Column<int>(nullable: false),
                    Estatus = table.Column<int>(nullable: false),
                    VencimientoPassword = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LUsuarios", x => x.idLUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Posiciones",
                schema: "usrfut7",
                columns: table => new
                {
                    idPosicion = table.Column<int>(nullable: false),
                    Posicion = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiciones", x => x.idPosicion);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                schema: "usrfut7",
                columns: table => new
                {
                    idVisita = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Mensaje = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.idVisita);
                });

            migrationBuilder.CreateTable(
                name: "Divisiones",
                columns: table => new
                {
                    idDivision = table.Column<int>(nullable: false),
                    idCategoria = table.Column<int>(nullable: false),
                    NombreDivision = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    EdadMinima = table.Column<int>(nullable: true),
                    EdadMaxima = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisiones", x => x.idDivision);
                    table.ForeignKey(
                        name: "FK_Divisiones_Categorias",
                        column: x => x.idCategoria,
                        principalTable: "Categorias",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prereservaciones",
                columns: table => new
                {
                    idPreReservacion = table.Column<int>(nullable: false),
                    NombreSolicitante = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Observaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime", nullable: true),
                    idHora = table.Column<int>(nullable: true),
                    FechaSolicitada = table.Column<DateTime>(type: "datetime", nullable: true),
                    Confirmado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prereservaciones", x => x.idPreReservacion);
                    table.ForeignKey(
                        name: "FK_Prereservaciones_Horas",
                        column: x => x.idHora,
                        principalTable: "Horas",
                        principalColumn: "idHora",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    idComentario = table.Column<int>(nullable: false),
                    Anio = table.Column<int>(nullable: false),
                    Mes = table.Column<int>(nullable: false),
                    Dia = table.Column<int>(nullable: false),
                    idParticipante = table.Column<int>(nullable: false),
                    idTema = table.Column<int>(nullable: false),
                    Comentario = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.idComentario);
                    table.ForeignKey(
                        name: "FK_Comentarios_Participantes",
                        column: x => x.idParticipante,
                        principalTable: "Participantes",
                        principalColumn: "idParticipante",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comentarios_Comentarios",
                        column: x => x.idTema,
                        principalTable: "Temas",
                        principalColumn: "idTema",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imagenes",
                columns: table => new
                {
                    idImagen = table.Column<int>(nullable: false),
                    idTema = table.Column<int>(nullable: false),
                    imagen = table.Column<byte[]>(type: "image", nullable: true),
                    ContentType = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes", x => x.idImagen);
                    table.ForeignKey(
                        name: "FK_Imagenes_Temas",
                        column: x => x.idTema,
                        principalTable: "Temas",
                        principalColumn: "idTema",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PermisosPorUsuario",
                columns: table => new
                {
                    idPermisoPorUsuario = table.Column<int>(nullable: false),
                    idModulo = table.Column<int>(nullable: true),
                    idUsuario = table.Column<int>(nullable: true),
                    idPermiso = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosPorUsuario", x => x.idPermisoPorUsuario);
                    table.ForeignKey(
                        name: "FK_PermisosPorUsuario_Modulos",
                        column: x => x.idModulo,
                        principalTable: "Modulos",
                        principalColumn: "idModulo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermisosPorUsuario_Permisos",
                        column: x => x.idPermiso,
                        principalTable: "Permisos",
                        principalColumn: "idPermiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermisosPorUsuario_Usuarios",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    idEquipo = table.Column<int>(nullable: false),
                    idCategoria = table.Column<int>(nullable: false),
                    idDivision = table.Column<int>(nullable: false),
                    NombreEquipo = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Delegado = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    DirTecnico = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    ColorCamiseta = table.Column<int>(nullable: true),
                    ColorShort = table.Column<int>(nullable: true),
                    Telefono = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Escudo = table.Column<byte[]>(type: "image", nullable: true),
                    ContentType = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Auxiliar = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Medico = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    ruta = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Apoyos = table.Column<int>(nullable: true),
                    fotoequipo = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.idEquipo);
                    table.ForeignKey(
                        name: "FK_Equipos_Categorias",
                        column: x => x.idCategoria,
                        principalTable: "Categorias",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Divisiones",
                        column: x => x.idDivision,
                        principalTable: "Divisiones",
                        principalColumn: "idDivision",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    idHorario = table.Column<int>(nullable: false),
                    idDivision = table.Column<int>(nullable: false),
                    Hora = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.idHorario);
                    table.ForeignKey(
                        name: "FK_Horarios_Divisiones",
                        column: x => x.idDivision,
                        principalTable: "Divisiones",
                        principalColumn: "idDivision",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    idTorneo = table.Column<int>(nullable: false),
                    idCategoria = table.Column<int>(nullable: true),
                    idDivision = table.Column<int>(nullable: true),
                    NombreTorneo = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    FechaApertura = table.Column<DateTime>(type: "datetime", nullable: true),
                    Abierto = table.Column<bool>(nullable: true),
                    Cerrado = table.Column<bool>(nullable: true),
                    FechaCierre = table.Column<DateTime>(type: "datetime", nullable: true),
                    DobleRonda = table.Column<bool>(nullable: true),
                    Publicado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.idTorneo);
                    table.ForeignKey(
                        name: "FK_Torneos_Categorias",
                        column: x => x.idCategoria,
                        principalTable: "Categorias",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Torneos_Divisiones",
                        column: x => x.idDivision,
                        principalTable: "Divisiones",
                        principalColumn: "idDivision",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    idJugador = table.Column<int>(nullable: false),
                    idEquipo = table.Column<int>(nullable: false),
                    idTipoJugador = table.Column<int>(nullable: false),
                    NombreJugador = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Telefono = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Numero = table.Column<int>(nullable: true),
                    Posicion = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Altura = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Peso = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Edad = table.Column<short>(nullable: false),
                    Fotografia = table.Column<byte[]>(type: "image", nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Observaciones = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TipoJugador = table.Column<int>(nullable: true),
                    Activo = table.Column<bool>(nullable: false),
                    ContentType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ruta = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Tomada = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.idJugador);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos",
                        column: x => x.idEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadores_TiposJugador",
                        column: x => x.idTipoJugador,
                        principalTable: "TiposJugador",
                        principalColumn: "idTipoJugador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosPorEquipo",
                columns: table => new
                {
                    IdUsuarioPorEquipo = table.Column<int>(nullable: false),
                    idEquipo = table.Column<int>(nullable: true),
                    idUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosPorEquipo", x => x.IdUsuarioPorEquipo);
                    table.ForeignKey(
                        name: "FK_UsuariosPorEquipo_Equipos",
                        column: x => x.idEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuariosPorEquipo_Usuarios",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    idCalendario = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: true),
                    idDia = table.Column<int>(nullable: true),
                    idHora = table.Column<int>(nullable: true),
                    Reservado = table.Column<bool>(nullable: true),
                    idTemporada = table.Column<int>(nullable: true),
                    idTorneo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.idCalendario);
                    table.ForeignKey(
                        name: "FK_Calendario_DiasSemana",
                        column: x => x.idDia,
                        principalTable: "DiasSemana",
                        principalColumn: "idDia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calendario_Horas",
                        column: x => x.idHora,
                        principalTable: "Horas",
                        principalColumn: "idHora",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calendario_Temporadas",
                        column: x => x.idTemporada,
                        principalTable: "Temporadas",
                        principalColumn: "idTemporada",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calendario_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiasPorTorneo",
                columns: table => new
                {
                    idDiaPorTorneo = table.Column<int>(nullable: false),
                    idTorneo = table.Column<int>(nullable: true),
                    idDia = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiasPorTorneo", x => x.idDiaPorTorneo);
                    table.ForeignKey(
                        name: "FK_DiasPorTorneo_DiasSemana",
                        column: x => x.idDia,
                        principalTable: "DiasSemana",
                        principalColumn: "idDia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiasPorTorneo_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Finalistas",
                columns: table => new
                {
                    idFinalista = table.Column<int>(nullable: false),
                    idTorneo = table.Column<int>(nullable: true),
                    idEquipo = table.Column<int>(nullable: false),
                    idGrupo = table.Column<int>(nullable: true),
                    Posinicial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finalistas", x => x.idFinalista);
                    table.ForeignKey(
                        name: "FK_Finalistas_Equipos",
                        column: x => x.idEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Finalistas_Grupos",
                        column: x => x.idGrupo,
                        principalTable: "Grupos",
                        principalColumn: "idGrupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Finalistas_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GruposDetalle",
                columns: table => new
                {
                    idGruposDetalle = table.Column<int>(nullable: false),
                    idGrupo = table.Column<int>(nullable: true),
                    idTorneo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposDetalle", x => x.idGruposDetalle);
                    table.ForeignKey(
                        name: "FK_GruposDetalle_Grupos",
                        column: x => x.idGrupo,
                        principalTable: "Grupos",
                        principalColumn: "idGrupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GruposDetalle_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    idInscripcion = table.Column<int>(nullable: false),
                    idTorneo = table.Column<int>(nullable: true),
                    idEquipo = table.Column<int>(nullable: true),
                    FechaInscripcion = table.Column<DateTime>(type: "datetime", nullable: true),
                    Residencia = table.Column<bool>(nullable: true),
                    Finalista = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.idInscripcion);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Equipos",
                        column: x => x.idEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jornadas",
                columns: table => new
                {
                    idJornada = table.Column<int>(nullable: false),
                    idTorneo = table.Column<int>(nullable: true),
                    NumRonda = table.Column<int>(nullable: true),
                    NumJornada = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    FechaInicial = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaFinal = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jornadas", x => x.idJornada);
                    table.ForeignKey(
                        name: "FK_Jornadas_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puntuacion",
                columns: table => new
                {
                    idPuntuacion = table.Column<int>(nullable: false),
                    idTorneo = table.Column<int>(nullable: true),
                    idEquipo = table.Column<int>(nullable: true),
                    PJ = table.Column<int>(nullable: true),
                    PG = table.Column<int>(nullable: true),
                    PP = table.Column<int>(nullable: true),
                    PE = table.Column<int>(nullable: true),
                    PFavor = table.Column<int>(nullable: true),
                    PContra = table.Column<int>(nullable: true),
                    GolFavor = table.Column<int>(nullable: true),
                    GolContra = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puntuacion", x => x.idPuntuacion);
                    table.ForeignKey(
                        name: "FK_Puntuacion_Equipos",
                        column: x => x.idEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Puntuacion_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CalendarioTorneos",
                columns: table => new
                {
                    idCalendarioTorneo = table.Column<int>(nullable: false),
                    idTorneo = table.Column<int>(nullable: true),
                    idCalendario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarioTorneos", x => x.idCalendarioTorneo);
                    table.ForeignKey(
                        name: "FK_CalendarioTorneos_Calendario",
                        column: x => x.idCalendario,
                        principalTable: "Calendario",
                        principalColumn: "idCalendario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CalendarioTorneos_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JuegosSF",
                columns: table => new
                {
                    idJuegoSF = table.Column<int>(nullable: false),
                    idCalendario = table.Column<int>(nullable: true),
                    EqVisitante = table.Column<int>(nullable: true),
                    EqLocal = table.Column<int>(nullable: true),
                    Activo = table.Column<bool>(nullable: false),
                    Ganador = table.Column<int>(nullable: true),
                    idTorneo = table.Column<int>(nullable: true),
                    NumJuego = table.Column<int>(nullable: false),
                    GolesVisitante = table.Column<int>(nullable: true),
                    GolesLocal = table.Column<int>(nullable: true),
                    Jornada = table.Column<int>(nullable: true),
                    idGrupo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuegosSF", x => x.idJuegoSF);
                    table.ForeignKey(
                        name: "FK_JuegosSF_Calendario",
                        column: x => x.idCalendario,
                        principalTable: "Calendario",
                        principalColumn: "idCalendario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JuegosSF_Grupos",
                        column: x => x.idGrupo,
                        principalTable: "Grupos",
                        principalColumn: "idGrupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JuegosSF_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservacionesDeEquipo",
                columns: table => new
                {
                    idReservacionDeEquipo = table.Column<int>(nullable: false),
                    idEquipo = table.Column<int>(nullable: true),
                    idTorneo = table.Column<int>(nullable: true),
                    idCalendario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservacionesDeEquipo", x => x.idReservacionDeEquipo);
                    table.ForeignKey(
                        name: "FK_ReservacionesDeEquipo_Calendario",
                        column: x => x.idCalendario,
                        principalTable: "Calendario",
                        principalColumn: "idCalendario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservacionesDeEquipo_Equipos",
                        column: x => x.idEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservacionesDeEquipo_Torneos",
                        column: x => x.idTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HorasPorDia",
                columns: table => new
                {
                    idHoraPorDia = table.Column<int>(nullable: false),
                    idDiaPorTorneo = table.Column<int>(nullable: true),
                    idHora = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorasPorDia", x => x.idHoraPorDia);
                    table.ForeignKey(
                        name: "FK_HorasPorDia_DiasPorTorneo",
                        column: x => x.idDiaPorTorneo,
                        principalTable: "DiasPorTorneo",
                        principalColumn: "idDiaPorTorneo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HorasPorDia_Horas",
                        column: x => x.idHora,
                        principalTable: "Horas",
                        principalColumn: "idHora",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    idJuego = table.Column<int>(nullable: false),
                    idJornada = table.Column<int>(nullable: true),
                    idCalendario = table.Column<int>(nullable: true),
                    Local = table.Column<int>(nullable: true),
                    Visitante = table.Column<int>(nullable: true),
                    Activo = table.Column<bool>(nullable: false),
                    Ganador = table.Column<int>(nullable: true),
                    IdTorneo = table.Column<int>(nullable: true),
                    Observaciones = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.idJuego);
                    table.ForeignKey(
                        name: "FK_Juegos_Torneos",
                        column: x => x.IdTorneo,
                        principalTable: "Torneos",
                        principalColumn: "idTorneo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Juegos_Calendario",
                        column: x => x.idCalendario,
                        principalTable: "Calendario",
                        principalColumn: "idCalendario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Juegos_Jornadas",
                        column: x => x.idJornada,
                        principalTable: "Jornadas",
                        principalColumn: "idJornada",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FechasDeJuego",
                columns: table => new
                {
                    idFechaDeJuego = table.Column<int>(nullable: false),
                    idJuego = table.Column<int>(nullable: true),
                    idCalendario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FechasDeJuego", x => x.idFechaDeJuego);
                    table.ForeignKey(
                        name: "FK_FechasDeJuego_Calendario",
                        column: x => x.idCalendario,
                        principalTable: "Calendario",
                        principalColumn: "idCalendario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FechasDeJuego_Juegos",
                        column: x => x.idJuego,
                        principalTable: "Juegos",
                        principalColumn: "idJuego",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Goles",
                columns: table => new
                {
                    idGol = table.Column<int>(nullable: false),
                    idJuego = table.Column<int>(nullable: false),
                    idEquipo = table.Column<int>(nullable: true),
                    idJugador = table.Column<int>(nullable: true),
                    MinutoAnotacion = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goles", x => x.idGol);
                    table.ForeignKey(
                        name: "FK_Goles_Equipos",
                        column: x => x.idEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goles_Juegos",
                        column: x => x.idJuego,
                        principalTable: "Juegos",
                        principalColumn: "idJuego",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goles_Jugadores",
                        column: x => x.idJugador,
                        principalTable: "Jugadores",
                        principalColumn: "idJugador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sanciones",
                columns: table => new
                {
                    idSancion = table.Column<int>(nullable: false),
                    idJuego = table.Column<int>(nullable: false),
                    idEquipo = table.Column<int>(nullable: false),
                    Sancionado = table.Column<int>(nullable: false),
                    idTipoSancion = table.Column<int>(nullable: false),
                    Motivo = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Castigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanciones", x => x.idSancion);
                    table.ForeignKey(
                        name: "FK_Sanciones_Equipos",
                        column: x => x.idEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sanciones_Juegos",
                        column: x => x.idJuego,
                        principalTable: "Juegos",
                        principalColumn: "idJuego",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sanciones_TiposSancion",
                        column: x => x.idTipoSancion,
                        principalTable: "TiposSancion",
                        principalColumn: "idTipoSancion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendario_idDia",
                table: "Calendario",
                column: "idDia");

            migrationBuilder.CreateIndex(
                name: "IX_Calendario_idHora",
                table: "Calendario",
                column: "idHora");

            migrationBuilder.CreateIndex(
                name: "IX_Calendario_idTemporada",
                table: "Calendario",
                column: "idTemporada");

            migrationBuilder.CreateIndex(
                name: "IX_Calendario_idTorneo",
                table: "Calendario",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarioTorneos_idCalendario",
                table: "CalendarioTorneos",
                column: "idCalendario");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarioTorneos_idTorneo",
                table: "CalendarioTorneos",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_idParticipante",
                table: "Comentarios",
                column: "idParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_idTema",
                table: "Comentarios",
                column: "idTema");

            migrationBuilder.CreateIndex(
                name: "IX_DiasPorTorneo_idDia",
                table: "DiasPorTorneo",
                column: "idDia");

            migrationBuilder.CreateIndex(
                name: "IX_DiasPorTorneo_idTorneo",
                table: "DiasPorTorneo",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Divisiones_idCategoria",
                table: "Divisiones",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_idCategoria",
                table: "Equipos",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_idDivision",
                table: "Equipos",
                column: "idDivision");

            migrationBuilder.CreateIndex(
                name: "IX_FechasDeJuego_idCalendario",
                table: "FechasDeJuego",
                column: "idCalendario");

            migrationBuilder.CreateIndex(
                name: "IX_FechasDeJuego_idJuego",
                table: "FechasDeJuego",
                column: "idJuego");

            migrationBuilder.CreateIndex(
                name: "IX_Finalistas_idEquipo",
                table: "Finalistas",
                column: "idEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Finalistas_idGrupo",
                table: "Finalistas",
                column: "idGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_Finalistas_idTorneo",
                table: "Finalistas",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Goles_idEquipo",
                table: "Goles",
                column: "idEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Goles_idJuego",
                table: "Goles",
                column: "idJuego");

            migrationBuilder.CreateIndex(
                name: "IX_Goles_idJugador",
                table: "Goles",
                column: "idJugador");

            migrationBuilder.CreateIndex(
                name: "IX_GruposDetalle_idGrupo",
                table: "GruposDetalle",
                column: "idGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_GruposDetalle_idTorneo",
                table: "GruposDetalle",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_idDivision",
                table: "Horarios",
                column: "idDivision");

            migrationBuilder.CreateIndex(
                name: "IX_HorasPorDia_idDiaPorTorneo",
                table: "HorasPorDia",
                column: "idDiaPorTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_HorasPorDia_idHora",
                table: "HorasPorDia",
                column: "idHora");

            migrationBuilder.CreateIndex(
                name: "IX_Imagenes_idTema",
                table: "Imagenes",
                column: "idTema");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_idEquipo",
                table: "Inscripciones",
                column: "idEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_idTorneo",
                table: "Inscripciones",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Jornadas_idTorneo",
                table: "Jornadas",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_IdTorneo",
                table: "Juegos",
                column: "IdTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_idCalendario",
                table: "Juegos",
                column: "idCalendario");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_idJornada",
                table: "Juegos",
                column: "idJornada");

            migrationBuilder.CreateIndex(
                name: "IX_JuegosSF_idCalendario",
                table: "JuegosSF",
                column: "idCalendario");

            migrationBuilder.CreateIndex(
                name: "IX_JuegosSF_idGrupo",
                table: "JuegosSF",
                column: "idGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_JuegosSF_idTorneo",
                table: "JuegosSF",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_idEquipo",
                table: "Jugadores",
                column: "idEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_idTipoJugador",
                table: "Jugadores",
                column: "idTipoJugador");

            migrationBuilder.CreateIndex(
                name: "IX_PermisosPorUsuario_idModulo",
                table: "PermisosPorUsuario",
                column: "idModulo");

            migrationBuilder.CreateIndex(
                name: "IX_PermisosPorUsuario_idPermiso",
                table: "PermisosPorUsuario",
                column: "idPermiso");

            migrationBuilder.CreateIndex(
                name: "IX_PermisosPorUsuario_idUsuario",
                table: "PermisosPorUsuario",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Prereservaciones_idHora",
                table: "Prereservaciones",
                column: "idHora");

            migrationBuilder.CreateIndex(
                name: "IX_Puntuacion_idEquipo",
                table: "Puntuacion",
                column: "idEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Puntuacion_idTorneo",
                table: "Puntuacion",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_ReservacionesDeEquipo_idCalendario",
                table: "ReservacionesDeEquipo",
                column: "idCalendario");

            migrationBuilder.CreateIndex(
                name: "IX_ReservacionesDeEquipo_idEquipo",
                table: "ReservacionesDeEquipo",
                column: "idEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_ReservacionesDeEquipo_idTorneo",
                table: "ReservacionesDeEquipo",
                column: "idTorneo");

            migrationBuilder.CreateIndex(
                name: "IX_Sanciones_idEquipo",
                table: "Sanciones",
                column: "idEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Sanciones_idJuego",
                table: "Sanciones",
                column: "idJuego");

            migrationBuilder.CreateIndex(
                name: "IX_Sanciones_idTipoSancion",
                table: "Sanciones",
                column: "idTipoSancion");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_idCategoria",
                table: "Torneos",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_idDivision",
                table: "Torneos",
                column: "idDivision");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPorEquipo_idEquipo",
                table: "UsuariosPorEquipo",
                column: "idEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPorEquipo_idUsuario",
                table: "UsuariosPorEquipo",
                column: "idUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "CalendarioTorneos");

            migrationBuilder.DropTable(
                name: "Colores");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "FechasDeJuego");

            migrationBuilder.DropTable(
                name: "Finalistas");

            migrationBuilder.DropTable(
                name: "Goles");

            migrationBuilder.DropTable(
                name: "GruposDetalle");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "HorasPorDia");

            migrationBuilder.DropTable(
                name: "Imagenes");

            migrationBuilder.DropTable(
                name: "Inscripciones");

            migrationBuilder.DropTable(
                name: "JuegosSF");

            migrationBuilder.DropTable(
                name: "PermisosPorUsuario");

            migrationBuilder.DropTable(
                name: "Prereservaciones");

            migrationBuilder.DropTable(
                name: "Puntuacion");

            migrationBuilder.DropTable(
                name: "ReservacionesDeEquipo");

            migrationBuilder.DropTable(
                name: "Sanciones");

            migrationBuilder.DropTable(
                name: "UsuariosPorEquipo");

            migrationBuilder.DropTable(
                name: "Llista",
                schema: "usrfut7");

            migrationBuilder.DropTable(
                name: "LUsuarios",
                schema: "usrfut7");

            migrationBuilder.DropTable(
                name: "Posiciones",
                schema: "usrfut7");

            migrationBuilder.DropTable(
                name: "Visitas",
                schema: "usrfut7");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "DiasPorTorneo");

            migrationBuilder.DropTable(
                name: "Temas");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Juegos");

            migrationBuilder.DropTable(
                name: "TiposSancion");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "TiposJugador");

            migrationBuilder.DropTable(
                name: "Calendario");

            migrationBuilder.DropTable(
                name: "Jornadas");

            migrationBuilder.DropTable(
                name: "DiasSemana");

            migrationBuilder.DropTable(
                name: "Horas");

            migrationBuilder.DropTable(
                name: "Temporadas");

            migrationBuilder.DropTable(
                name: "Torneos");

            migrationBuilder.DropTable(
                name: "Divisiones");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MiFutLiga.Models
{
    public partial class MiFutMovilContext_11 : DbContext
    {
        public MiFutMovilContext_11()
        {
        }

        public MiFutMovilContext_11(DbContextOptions<MiFutMovilContext_11> options)
            : base(options)
        {
        }

        public virtual DbSet<Administradores> Administradores { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Calendario> Calendario { get; set; }
        public virtual DbSet<CalendarioTorneos> CalendarioTorneos { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Colores> Colores { get; set; }
        public virtual DbSet<Comentarios> Comentarios { get; set; }
        public virtual DbSet<DiasPorTorneo> DiasPorTorneo { get; set; }
        public virtual DbSet<DiasSemana> DiasSemana { get; set; }
        public virtual DbSet<Divisiones> Divisiones { get; set; }
        public virtual DbSet<Equipos> Equipos { get; set; }
        public virtual DbSet<FechasDeJuego> FechasDeJuego { get; set; }
        public virtual DbSet<Finalistas> Finalistas { get; set; }
        public virtual DbSet<Goles> Goles { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<GruposDetalle> GruposDetalle { get; set; }
        public virtual DbSet<Horarios> Horarios { get; set; }
        public virtual DbSet<Horas> Horas { get; set; }
        public virtual DbSet<HorasPorDia> HorasPorDia { get; set; }
        public virtual DbSet<Imagenes> Imagenes { get; set; }
        public virtual DbSet<Inscripciones> Inscripciones { get; set; }
        public virtual DbSet<Jornadas> Jornadas { get; set; }
        public virtual DbSet<Juegos> Juegos { get; set; }
        public virtual DbSet<JuegosSF> JuegosSF { get; set; }
        public virtual DbSet<Jugadores> Jugadores { get; set; }
        public virtual DbSet<LUsuarios> LUsuarios { get; set; }
        public virtual DbSet<Llista> Llista { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<Noticias> Noticias { get; set; }
        public virtual DbSet<Participantes> Participantes { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<PermisosPorUsuario> PermisosPorUsuario { get; set; }
        public virtual DbSet<Posiciones> Posiciones { get; set; }
        public virtual DbSet<Prereservaciones> Prereservaciones { get; set; }
        public virtual DbSet<Puntuacion> Puntuacion { get; set; }
        public virtual DbSet<ReservacionesDeEquipo> ReservacionesDeEquipo { get; set; }
        public virtual DbSet<Sanciones> Sanciones { get; set; }
        public virtual DbSet<Temas> Temas { get; set; }
        public virtual DbSet<Temporadas> Temporadas { get; set; }
        public virtual DbSet<TiposJugador> TiposJugador { get; set; }
        public virtual DbSet<TiposSancion> TiposSancion { get; set; }
        public virtual DbSet<Torneos> Torneos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosPorEquipo> UsuariosPorEquipo { get; set; }
        public virtual DbSet<Visitas> Visitas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8U49RG5\\MSSQLSERVER2019;Database=MiFutMovil;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administradores>(entity =>
            {
                entity.HasKey(e => e.idAdministrador);

                entity.Property(e => e.idAdministrador).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NormalizedEmail)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Calendario>(entity =>
            {
                entity.HasKey(e => e.idCalendario);

                entity.HasIndex(e => e.idDia);

                entity.HasIndex(e => e.idHora);

                entity.HasIndex(e => e.idTemporada);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idCalendario).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idDiaNavigation)
                    .WithMany(p => p.Calendario)
                    .HasForeignKey(d => d.idDia)
                    .HasConstraintName("FK_Calendario_DiasSemana");

                entity.HasOne(d => d.idHoraNavigation)
                    .WithMany(p => p.Calendario)
                    .HasForeignKey(d => d.idHora)
                    .HasConstraintName("FK_Calendario_Horas");

                entity.HasOne(d => d.idTemporadaNavigation)
                    .WithMany(p => p.Calendario)
                    .HasForeignKey(d => d.idTemporada)
                    .HasConstraintName("FK_Calendario_Temporadas");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.Calendario)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_Calendario_Torneos");
            });

            modelBuilder.Entity<CalendarioTorneos>(entity =>
            {
                entity.HasKey(e => e.idCalendarioTorneo);

                entity.HasIndex(e => e.idCalendario);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idCalendarioTorneo).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idCalendarioNavigation)
                    .WithMany(p => p.CalendarioTorneos)
                    .HasForeignKey(d => d.idCalendario)
                    .HasConstraintName("FK_CalendarioTorneos_Calendario");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.CalendarioTorneos)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_CalendarioTorneos_Torneos");
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasKey(e => e.idCategoria);

                entity.Property(e => e.idCategoria).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombreCategoria)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Colores>(entity =>
            {
                entity.HasKey(e => e.idColor);

                entity.Property(e => e.idColor).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Comentarios>(entity =>
            {
                entity.HasKey(e => e.idComentario);

                entity.HasIndex(e => e.idParticipante);

                entity.HasIndex(e => e.idTema);

                entity.Property(e => e.idComentario).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idParticipanteNavigation)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.idParticipante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comentarios_Participantes");

                entity.HasOne(d => d.idTemaNavigation)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.idTema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comentarios_Comentarios");
            });

            modelBuilder.Entity<DiasPorTorneo>(entity =>
            {
                entity.HasKey(e => e.idDiaPorTorneo);

                entity.HasIndex(e => e.idDia);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idDiaPorTorneo).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idDiaNavigation)
                    .WithMany(p => p.DiasPorTorneo)
                    .HasForeignKey(d => d.idDia)
                    .HasConstraintName("FK_DiasPorTorneo_DiasSemana");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.DiasPorTorneo)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_DiasPorTorneo_Torneos");
            });

            modelBuilder.Entity<DiasSemana>(entity =>
            {
                entity.HasKey(e => e.idDia);

                entity.Property(e => e.idDia).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Divisiones>(entity =>
            {
                entity.HasKey(e => e.idDivision);

                entity.HasIndex(e => e.idCategoria);

                entity.Property(e => e.idDivision).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombreDivision)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.idCategoriaNavigation)
                    .WithMany(p => p.Divisiones)
                    .HasForeignKey(d => d.idCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Divisiones_Categorias");
            });

            modelBuilder.Entity<Equipos>(entity =>
            {
                entity.HasKey(e => e.idEquipo);

                entity.HasIndex(e => e.idCategoria);

                entity.HasIndex(e => e.idDivision);

                entity.Property(e => e.idEquipo).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Auxiliar)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Delegado)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DirTecnico)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Escudo).HasColumnType("image");

                entity.Property(e => e.Medico)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombreEquipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.fotoequipo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ruta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.idCategoriaNavigation)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.idCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipos_Categorias");

                entity.HasOne(d => d.idDivisionNavigation)
                    .WithMany(p => p.Equipos)
                    .HasForeignKey(d => d.idDivision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipos_Divisiones");
            });

            modelBuilder.Entity<FechasDeJuego>(entity =>
            {
                entity.HasKey(e => e.idFechaDeJuego);

                entity.HasIndex(e => e.idCalendario);

                entity.HasIndex(e => e.idJuego);

                entity.Property(e => e.idFechaDeJuego).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idCalendarioNavigation)
                    .WithMany(p => p.FechasDeJuego)
                    .HasForeignKey(d => d.idCalendario)
                    .HasConstraintName("FK_FechasDeJuego_Calendario");

                entity.HasOne(d => d.idJuegoNavigation)
                    .WithMany(p => p.FechasDeJuego)
                    .HasForeignKey(d => d.idJuego)
                    .HasConstraintName("FK_FechasDeJuego_Juegos");
            });

            modelBuilder.Entity<Finalistas>(entity =>
            {
                entity.HasKey(e => e.idFinalista);

                entity.HasIndex(e => e.idEquipo);

                entity.HasIndex(e => e.idGrupo);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idFinalista).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idEquipoNavigation)
                    .WithMany(p => p.Finalistas)
                    .HasForeignKey(d => d.idEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Finalistas_Equipos");

                entity.HasOne(d => d.idGrupoNavigation)
                    .WithMany(p => p.Finalistas)
                    .HasForeignKey(d => d.idGrupo)
                    .HasConstraintName("FK_Finalistas_Grupos");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.Finalistas)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_Finalistas_Torneos");
            });

            modelBuilder.Entity<Goles>(entity =>
            {
                entity.HasKey(e => e.idGol);

                entity.HasIndex(e => e.idEquipo);

                entity.HasIndex(e => e.idJuego);

                entity.HasIndex(e => e.idJugador);

                entity.Property(e => e.idGol).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.MinutoAnotacion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idEquipoNavigation)
                    .WithMany(p => p.Goles)
                    .HasForeignKey(d => d.idEquipo)
                    .HasConstraintName("FK_Goles_Equipos");

                entity.HasOne(d => d.idJuegoNavigation)
                    .WithMany(p => p.Goles)
                    .HasForeignKey(d => d.idJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goles_Juegos");

                entity.HasOne(d => d.idJugadorNavigation)
                    .WithMany(p => p.Goles)
                    .HasForeignKey(d => d.idJugador)
                    .HasConstraintName("FK_Goles_Jugadores");
            });

            modelBuilder.Entity<Grupos>(entity =>
            {
                entity.HasKey(e => e.idGrupo);

                entity.Property(e => e.idGrupo).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombreGrupo)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GruposDetalle>(entity =>
            {
                entity.HasKey(e => e.idGruposDetalle);

                entity.HasIndex(e => e.idGrupo);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idGruposDetalle).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idGrupoNavigation)
                    .WithMany(p => p.GruposDetalle)
                    .HasForeignKey(d => d.idGrupo)
                    .HasConstraintName("FK_GruposDetalle_Grupos");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.GruposDetalle)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_GruposDetalle_Torneos");
            });

            modelBuilder.Entity<Horarios>(entity =>
            {
                entity.HasKey(e => e.idHorario);

                entity.HasIndex(e => e.idDivision);

                entity.Property(e => e.idHorario).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idDivisionNavigation)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.idDivision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Horarios_Divisiones");
            });

            modelBuilder.Entity<Horas>(entity =>
            {
                entity.HasKey(e => e.idHora);

                entity.Property(e => e.idHora).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<HorasPorDia>(entity =>
            {
                entity.HasKey(e => e.idHoraPorDia);

                entity.HasIndex(e => e.idDiaPorTorneo);

                entity.HasIndex(e => e.idHora);

                entity.Property(e => e.idHoraPorDia).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idDiaPorTorneoNavigation)
                    .WithMany(p => p.HorasPorDia)
                    .HasForeignKey(d => d.idDiaPorTorneo)
                    .HasConstraintName("FK_HorasPorDia_DiasPorTorneo");

                entity.HasOne(d => d.idHoraNavigation)
                    .WithMany(p => p.HorasPorDia)
                    .HasForeignKey(d => d.idHora)
                    .HasConstraintName("FK_HorasPorDia_Horas");
            });

            modelBuilder.Entity<Imagenes>(entity =>
            {
                entity.HasKey(e => e.idImagen);

                entity.HasIndex(e => e.idTema);

                entity.Property(e => e.idImagen).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.ContentType)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.imagen).HasColumnType("image");

                entity.HasOne(d => d.idTemaNavigation)
                    .WithMany(p => p.Imagenes)
                    .HasForeignKey(d => d.idTema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Imagenes_Temas");
            });

            modelBuilder.Entity<Inscripciones>(entity =>
            {
                entity.HasKey(e => e.idInscripcion);

                entity.HasIndex(e => e.idEquipo);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idInscripcion).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.FechaInscripcion).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idEquipoNavigation)
                    .WithMany(p => p.Inscripciones)
                    .HasForeignKey(d => d.idEquipo)
                    .HasConstraintName("FK_Inscripciones_Equipos");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.Inscripciones)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_Inscripciones_Torneos");
            });

            modelBuilder.Entity<Jornadas>(entity =>
            {
                entity.HasKey(e => e.idJornada);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idJornada).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicial).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NumJornada)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.Jornadas)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_Jornadas_Torneos");
            });

            modelBuilder.Entity<Juegos>(entity =>
            {
                entity.HasKey(e => e.idJuego);

                entity.HasIndex(e => e.IdTorneo);

                entity.HasIndex(e => e.idCalendario);

                entity.HasIndex(e => e.idJornada);

                entity.Property(e => e.idJuego).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTorneoNavigation)
                    .WithMany(p => p.Juegos)
                    .HasForeignKey(d => d.IdTorneo)
                    .HasConstraintName("FK_Juegos_Torneos");

                entity.HasOne(d => d.idCalendarioNavigation)
                    .WithMany(p => p.Juegos)
                    .HasForeignKey(d => d.idCalendario)
                    .HasConstraintName("FK_Juegos_Calendario");

                entity.HasOne(d => d.idJornadaNavigation)
                    .WithMany(p => p.Juegos)
                    .HasForeignKey(d => d.idJornada)
                    .HasConstraintName("FK_Juegos_Jornadas");
            });

            modelBuilder.Entity<JuegosSF>(entity =>
            {
                entity.HasKey(e => e.idJuegoSF);

                entity.HasIndex(e => e.idCalendario);

                entity.HasIndex(e => e.idGrupo);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idJuegoSF).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idCalendarioNavigation)
                    .WithMany(p => p.JuegosSF)
                    .HasForeignKey(d => d.idCalendario)
                    .HasConstraintName("FK_JuegosSF_Calendario");

                entity.HasOne(d => d.idGrupoNavigation)
                    .WithMany(p => p.JuegosSF)
                    .HasForeignKey(d => d.idGrupo)
                    .HasConstraintName("FK_JuegosSF_Grupos");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.JuegosSF)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_JuegosSF_Torneos");
            });

            modelBuilder.Entity<Jugadores>(entity =>
            {
                entity.HasKey(e => e.idJugador);

                entity.HasIndex(e => e.idEquipo);

                entity.HasIndex(e => e.idTipoJugador);

                entity.Property(e => e.idJugador).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Altura).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Fotografia).HasColumnType("image");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombreJugador)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Peso).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Posicion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ruta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.idEquipoNavigation)
                    .WithMany(p => p.Jugadores)
                    .HasForeignKey(d => d.idEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jugadores_Equipos");

                entity.HasOne(d => d.idTipoJugadorNavigation)
                    .WithMany(p => p.Jugadores)
                    .HasForeignKey(d => d.idTipoJugador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jugadores_TiposJugador");
            });

            modelBuilder.Entity<LUsuarios>(entity =>
            {
                entity.HasKey(e => e.idLUsuario);

                entity.ToTable("LUsuarios", "usrfut7");

                entity.Property(e => e.idLUsuario).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VencimientoPassword).HasColumnType("datetime");
            });

            modelBuilder.Entity<Llista>(entity =>
            {
                entity.HasKey(e => e.idLLista);

                entity.ToTable("Llista", "usrfut7");

                entity.Property(e => e.idLLista).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Modulos>(entity =>
            {
                entity.HasKey(e => e.idModulo);

                entity.Property(e => e.idModulo).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Noticias>(entity =>
            {
                entity.HasKey(e => e.id_Noticias);

                entity.Property(e => e.id_Noticias).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Campo1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contenido).IsUnicode(false);

                entity.Property(e => e.Fecha_publica).HasColumnType("date");

                entity.Property(e => e.Imagen1).HasColumnType("image");

                entity.Property(e => e.Imagen2).HasColumnType("image");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Resumen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Participantes>(entity =>
            {
                entity.HasKey(e => e.idParticipante);

                entity.Property(e => e.idParticipante).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permisos>(entity =>
            {
                entity.HasKey(e => e.idPermiso);

                entity.Property(e => e.idPermiso).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<PermisosPorUsuario>(entity =>
            {
                entity.HasKey(e => e.idPermisoPorUsuario);

                entity.HasIndex(e => e.idModulo);

                entity.HasIndex(e => e.idPermiso);

                entity.HasIndex(e => e.idUsuario);

                entity.Property(e => e.idPermisoPorUsuario).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idModuloNavigation)
                    .WithMany(p => p.PermisosPorUsuario)
                    .HasForeignKey(d => d.idModulo)
                    .HasConstraintName("FK_PermisosPorUsuario_Modulos");

                entity.HasOne(d => d.idPermisoNavigation)
                    .WithMany(p => p.PermisosPorUsuario)
                    .HasForeignKey(d => d.idPermiso)
                    .HasConstraintName("FK_PermisosPorUsuario_Permisos");

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.PermisosPorUsuario)
                    .HasForeignKey(d => d.idUsuario)
                    .HasConstraintName("FK_PermisosPorUsuario_Usuarios");
            });

            modelBuilder.Entity<Posiciones>(entity =>
            {
                entity.HasKey(e => e.idPosicion);

                entity.ToTable("Posiciones", "usrfut7");

                entity.Property(e => e.idPosicion).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Posicion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prereservaciones>(entity =>
            {
                entity.HasKey(e => e.idPreReservacion);

                entity.HasIndex(e => e.idHora);

                entity.Property(e => e.idPreReservacion).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaSolicitada).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombreSolicitante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.idHoraNavigation)
                    .WithMany(p => p.Prereservaciones)
                    .HasForeignKey(d => d.idHora)
                    .HasConstraintName("FK_Prereservaciones_Horas");
            });

            modelBuilder.Entity<Puntuacion>(entity =>
            {
                entity.HasKey(e => e.idPuntuacion);

                entity.HasIndex(e => e.idEquipo);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idPuntuacion).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idEquipoNavigation)
                    .WithMany(p => p.Puntuacion)
                    .HasForeignKey(d => d.idEquipo)
                    .HasConstraintName("FK_Puntuacion_Equipos");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.Puntuacion)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_Puntuacion_Torneos");
            });

            modelBuilder.Entity<ReservacionesDeEquipo>(entity =>
            {
                entity.HasKey(e => e.idReservacionDeEquipo);

                entity.HasIndex(e => e.idCalendario);

                entity.HasIndex(e => e.idEquipo);

                entity.HasIndex(e => e.idTorneo);

                entity.Property(e => e.idReservacionDeEquipo).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idCalendarioNavigation)
                    .WithMany(p => p.ReservacionesDeEquipo)
                    .HasForeignKey(d => d.idCalendario)
                    .HasConstraintName("FK_ReservacionesDeEquipo_Calendario");

                entity.HasOne(d => d.idEquipoNavigation)
                    .WithMany(p => p.ReservacionesDeEquipo)
                    .HasForeignKey(d => d.idEquipo)
                    .HasConstraintName("FK_ReservacionesDeEquipo_Equipos");

                entity.HasOne(d => d.idTorneoNavigation)
                    .WithMany(p => p.ReservacionesDeEquipo)
                    .HasForeignKey(d => d.idTorneo)
                    .HasConstraintName("FK_ReservacionesDeEquipo_Torneos");
            });

            modelBuilder.Entity<Sanciones>(entity =>
            {
                entity.HasKey(e => e.idSancion);

                entity.HasIndex(e => e.idEquipo);

                entity.HasIndex(e => e.idJuego);

                entity.HasIndex(e => e.idTipoSancion);

                entity.Property(e => e.idSancion).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.idEquipoNavigation)
                    .WithMany(p => p.Sanciones)
                    .HasForeignKey(d => d.idEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sanciones_Equipos");

                entity.HasOne(d => d.idJuegoNavigation)
                    .WithMany(p => p.Sanciones)
                    .HasForeignKey(d => d.idJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sanciones_Juegos");

                entity.HasOne(d => d.idTipoSancionNavigation)
                    .WithMany(p => p.Sanciones)
                    .HasForeignKey(d => d.idTipoSancion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sanciones_TiposSancion");
            });

            modelBuilder.Entity<Temas>(entity =>
            {
                entity.HasKey(e => e.idTema);

                entity.Property(e => e.idTema).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Temporadas>(entity =>
            {
                entity.HasKey(e => e.idTemporada);

                entity.Property(e => e.idTemporada).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<TiposJugador>(entity =>
            {
                entity.HasKey(e => e.idTipoJugador);

                entity.Property(e => e.idTipoJugador).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<TiposSancion>(entity =>
            {
                entity.HasKey(e => e.idTipoSancion);

                entity.Property(e => e.idTipoSancion).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Torneos>(entity =>
            {
                entity.HasKey(e => e.idTorneo);

                entity.HasIndex(e => e.idCategoria);

                entity.HasIndex(e => e.idDivision);

                entity.Property(e => e.idTorneo).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.FechaApertura).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NombreTorneo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.idCategoriaNavigation)
                    .WithMany(p => p.Torneos)
                    .HasForeignKey(d => d.idCategoria)
                    .HasConstraintName("FK_Torneos_Categorias");

                entity.HasOne(d => d.idDivisionNavigation)
                    .WithMany(p => p.Torneos)
                    .HasForeignKey(d => d.idDivision)
                    .HasConstraintName("FK_Torneos_Divisiones");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.idUsuario);

                entity.Property(e => e.idUsuario).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Login)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuariosPorEquipo>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioPorEquipo);

                entity.HasIndex(e => e.idEquipo);

                entity.HasIndex(e => e.idUsuario);

                entity.Property(e => e.IdUsuarioPorEquipo).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.HasOne(d => d.idEquipoNavigation)
                    .WithMany(p => p.UsuariosPorEquipo)
                    .HasForeignKey(d => d.idEquipo)
                    .HasConstraintName("FK_UsuariosPorEquipo_Equipos");

                entity.HasOne(d => d.idUsuarioNavigation)
                    .WithMany(p => p.UsuariosPorEquipo)
                    .HasForeignKey(d => d.idUsuario)
                    .HasConstraintName("FK_UsuariosPorEquipo_Usuarios");
            });

            modelBuilder.Entity<Visitas>(entity =>
            {
                entity.HasKey(e => e.idVisita);

                entity.ToTable("Visitas", "usrfut7");

                entity.Property(e => e.idVisita).ValueGeneratedNever();

                entity.Property(e => e.Agregado).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

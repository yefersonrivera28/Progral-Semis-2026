CREATE TABLE usuarios_usis018804 (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    usuario VARCHAR(16) NOT NULL UNIQUE,
    clave VARCHAR(35) NOT NULL,
    nombre VARCHAR(65) NOT NULL,
    direccion VARCHAR(85) NOT NULL,
    telefono VARCHAR(9) NOT NULL
);

INSERT INTO usuarios_usis018804 (usuario, clave, nombre, direccion, telefono)
VALUES 
('admin123', 'Pass1234', 'Juan Pérez', 'Usulután, El Salvador', '7890-1234'),
('usuario1', 'Clave2026', 'Maria López', 'San Salvador, El Salvador', '7123-4567'),
('invitado', 'Guest5678', 'Carlos Gómez', 'San Miguel, El Salvador', '7567-8901');
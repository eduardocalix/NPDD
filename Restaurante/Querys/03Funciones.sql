USE DBRestauranteMarias
GO


CREATE FUNCTION Utilidad.NombrePropios
(
	@cadenaDeIngreso VARCHAR(2000)
)
RETURNS VARCHAR(2000) AS
BEGIN
	-- Colocar todo el texto en minúsculas
	SET @cadenaDeIngreso = LOWER(@cadenaDeIngreso);

	-- Luego buscar el primer caracter de la cadena y
	-- convertirlo a mayúscula
	SET @cadenaDeIngreso = STUFF(@cadenaDeIngreso, 1, 1, UPPER(SUBSTRING(@cadenaDeIngreso, 1, 1)));

	-- Inicializar una variable que sea igual al segundo caracter
	DECLARE @i INT = 2;

	-- Recorrer toda la cadena de caracteres hasta el final
	WHILE @i < LEN(@cadenaDeIngreso)
	BEGIN
		-- Si el caracter es un espacio
		IF SUBSTRING(@cadenaDeIngreso, @i, 1) = ' '
		BEGIN
			SET @cadenaDeIngreso = STUFF(@cadenaDeIngreso, @i + 1, 1, UPPER(SUBSTRING(@cadenaDeIngreso, @i + 1,1)));
		END
		-- Incrementar el contador
		SET @i = @i + 1
	END
	RETURN @cadenaDeIngreso
END;
GO
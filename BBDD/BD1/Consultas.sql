/*SELECT * 
FROM Persona, Entrada; /* Producto cartesiano */

SELECT * 
FROM Persona 
INNER JOIN Entrada ON Persona.DNI = Entrada.Persona_DNI;

SELECT * 
FROM Persona 
RIGHT JOIN Entrada ON Persona.DNI = Entrada.Persona_DNI;

SELECT * 
FROM Persona 
LEFT JOIN Entrada ON Persona.DNI = Entrada.Persona_DNI;
*/
SELECT Persona.DNI, CONCAT(Persona.Nombre, ' ', Persona.Apellidos) AS 'Persona', Entrada.Id, Sesion.Id, Sesion.Pelicula_ISBN, Pelicula.Titulo
FROM Persona
INNER JOIN Entrada ON Persona.DNI = Entrada.Persona_DNI
INNER JOIN Sesion ON Entrada.Sesion = Sesion.Id
INNER JOIN Pelicula ON Sesion.Pelicula_ISBN = Pelicula.ISBN;



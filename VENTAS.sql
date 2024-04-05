CREATE DATABASE VENTAS

CREATE TABLE VENTA (
IDVENTA INT IDENTITY (1,1) NOT NULL,
FECHA DATETIME NOT NULL,
TOTAL MONEY NOT NULL,
PRIMARY KEY (IDVENTA),
);

CREATE TABLE PRODUCTOS (
IDPRODUCTO INT IDENTITY (1,1) NOT NULL,
IDVENTA INT NOT NULL,
NOMBREPRODUCTO NVARCHAR (100) NOT NULL,
PRECIOUNITARIO MONEY NOT NULL,
PRIMARY KEY (IDPRODUCTO),
FOREIGN KEY (IDVENTA) REFERENCES VENTA(IDVENTA)
);


CREATE TABLE DETALLEVENTA (
IDDETALLEVENTA INT IDENTITY (1,1) NOT NULL,
IDVENTA INT NOT NULL,
IDPRODUCTO INT NOT NULL,
CANTIDAD  INT NOT NULL,
PRECIOVENTA MONEY NOT NULL,
TOTAL MONEY NOT NULL,
PRIMARY KEY (IDDETALLEVENTA),
FOREIGN KEY (IDVENTA) REFERENCES VENTA (IDVENTA),
FOREIGN KEY (IDPRODUCTO) REFERENCES PRODUCTOS (IDPRODUCTO),
);



insert into VENTA values ('2022-09-01 12:47:29', 10);
insert into VENTA values ('2022-09-01 12:50:56', 11);
insert into VENTA values ('2022-12-01 11:34:09', 12);
insert into VENTA values ('2022-12-01 11:40:10', 13);
insert into VENTA values ('2022-01-01 12:36:59', 18);
insert into VENTA values ('2022-01-01 12:40:45', 19);
insert into VENTA values ('2022-02-01 04:16:28', 20);
insert into VENTA values ('2022-02-01 04:19:53', 10);
insert into VENTA values ('2022-02-01 08:20:08', 30);
insert into VENTA values ('2022-02-01 08:44:34', 20);
insert into VENTA values ('2022-10-01 16:30:18', 20);

SELECT* FROM VENTA


insert into PRODUCTOS  values (1, 'Leche Pil', 6);
insert into PRODUCTOS  values (2, 'Karpil', 1);
insert into PRODUCTOS  values (1, 'PilFrut', 1);
insert into PRODUCTOS  values (2, 'Leche Pasteorizada', 7);
insert into PRODUCTOS  values (1, 'Pura Vida', 10);
insert into PRODUCTOS  values (2, 'Yogurt Boy', 2);
insert into PRODUCTOS  values (3, 'Coca Cola', 10);
insert into PRODUCTOS  values (3, 'Sprit', 10);
insert into PRODUCTOS  values (3, 'Fanta', 10);
insert into PRODUCTOS  values (3, 'Pepsi', 11);
insert into PRODUCTOS  values (3, 'Cascada', 10);
insert into PRODUCTOS  values (4, 'Pavo', 30);
insert into PRODUCTOS  values (4, 'Pollo', 25);
insert into PRODUCTOS  values (4, 'Cerdo', 40);
insert into PRODUCTOS  values (4, 'Hamburguesa', 10);
insert into PRODUCTOS  values (4, 'Fiambres', 25);
insert into PRODUCTOS  values (4, 'Costilla', 45);
insert into PRODUCTOS  values (14, 'KitKat', 10);
insert into PRODUCTOS  values (14, 'Nan', 10);
insert into PRODUCTOS  values (14, 'Nido', 15);
insert into PRODUCTOS  values (14, 'NesCafe', 20);
insert into PRODUCTOS  values (15, 'Nesquik', 25);

SELECT* FROM PRODUCTOS

insert into DETALLEVENTA values (1, 1, 2, 6, 12);
insert into DETALLEVENTA values (2, 2, 5, 1, 5);
insert into DETALLEVENTA values (1, 3, 4, 1, 4);
insert into DETALLEVENTA values (2, 4, 2, 7, 14);
insert into DETALLEVENTA values (1, 5, 1, 10, 10);
insert into DETALLEVENTA values (2, 6, 3, 2, 6);
insert into DETALLEVENTA values (3, 7, 1, 10, 10);
insert into DETALLEVENTA values (3, 8, 2, 10, 20);
insert into DETALLEVENTA values (3, 9, 1, 10, 10);
insert into DETALLEVENTA values (3, 10, 1, 11, 22);
insert into DETALLEVENTA values (3, 11, 1, 10, 10);
insert into DETALLEVENTA values (4, 12, 1, 30, 30);
insert into DETALLEVENTA values (4, 13, 1, 25, 25);
insert into DETALLEVENTA values (4, 14, 1, 40, 40);
insert into DETALLEVENTA values (4, 15, 5, 10, 50);
insert into DETALLEVENTA values (4, 16, 1, 25, 25);
insert into DETALLEVENTA values (4, 17, 1, 45, 45);
insert into DETALLEVENTA values (14, 18, 2, 10, 20);
insert into DETALLEVENTA values (14, 19, 1, 10, 10);
insert into DETALLEVENTA values (14, 20, 1, 15, 15);
insert into DETALLEVENTA values (14, 21, 1, 20, 20);
insert into DETALLEVENTA values (15, 22, 1, 25, 25);

SELECT* FROM DETALLEVENTA

SELECT DETALLEVENTA.IDPRODUCTO, PRODUCTOS.NOMBREPRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.TOTAL
FROM     DETALLEVENTA INNER JOIN
                  PRODUCTOS ON DETALLEVENTA.IDPRODUCTO = PRODUCTOS.IDPRODUCTO





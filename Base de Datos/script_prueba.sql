#TABLA USUARIOS
INSERT INTO USUARIO VALUES(1,'ANA','RUIZ','1111','ANA@CORREO',12345678);
INSERT INTO USUARIO VALUES(2,'JUAN','PEREZ','2222','JUAN@CORREO',98765432);
INSERT INTO USUARIO VALUES(3,'PEDRO','JUAREZ','3333','PEDRO@CORREO',22223333);
INSERT INTO USUARIO VALUES(4,'SOFIA','GARCIA','4444','SOFIA@CORREO',44445555);
INSERT INTO USUARIO VALUES(5,'NORMA','DE LA CRUZ','5555','NORMA@CORREO',66667777);
INSERT INTO USUARIO VALUES(6,'ROSA','ORELLANA','6666','ROSA@CORREO',18888999);
INSERT INTO USUARIO VALUES(7,'ROLANDO','MATA','7777','ROLANDO@CORREO',22225555);
INSERT INTO USUARIO VALUES(8,'DAVID','MARTINEZ','8888','DAVID@CORREO',12224555);
INSERT INTO USUARIO VALUES(9,'IVAN','FUENTES','9999','IVAN@CORREO',22226666);
INSERT INTO USUARIO VALUES(10,'KARLA','CABALLEROS','0000','KARLA@CORREO',22229999);
#TABLA PERFIL
INSERT INTO PERFIL VALUES (1,'PERFIL1','DESCRIPCION1');
INSERT INTO PERFIL VALUES (2,'PERFIL2','DESCRIPCION2');
INSERT INTO PERFIL VALUES (3,'PERFIL3','DESCRIPCION3');
INSERT INTO PERFIL VALUES (4,'PERFIL4','DESCRIPCION4');
INSERT INTO PERFIL VALUES (5,'PERFIL5','DESCRIPCION5');
INSERT INTO PERFIL VALUES (6,'PERFIL6','DESCRIPCION6');
INSERT INTO PERFIL VALUES (7,'PERFIL7','DESCRIPCION7');
INSERT INTO PERFIL VALUES (8,'PERFIL8','DESCRIPCION8');
INSERT INTO PERFIL VALUES (9,'PERFIL9','DESCRIPCION9');
INSERT INTO PERFIL VALUES (10,'PERFIL10','DESCRIPCION10');
#TABLA DETALLE_USUARIO_PERFIL
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(1,1);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(2,2);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(3,3);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(4,4);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(5,5);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(6,6);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(7,7);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(8,8);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(9,9);
INSERT INTO DETALLE_USUARIO_PERFIL VALUES(10,10);
#TABLA APLICACION
INSERT INTO APLICACION VALUES(1,'APLICACION1','DESC APLI1',1,1);
INSERT INTO APLICACION VALUES(2,'APLICACION2','DESC APLI2',1,2);
INSERT INTO APLICACION VALUES(3,'APLICACION3','DESC APLI3',1,3);
INSERT INTO APLICACION VALUES(4,'APLICACION4','DESC APLI4',1,4);
INSERT INTO APLICACION VALUES(5,'APLICACION5','DESC APLI5',1,5);
INSERT INTO APLICACION VALUES(6,'APLICACION6','DESC APLI6',1,6);
INSERT INTO APLICACION VALUES(7,'APLICACION7','DESC APLI7',1,7);
#TABLA DETALLE_PERFIL_APLICACION
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(1,1);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(2,2);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(3,3);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(4,4);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(5,5);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(6,6);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(7,7);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(8,1);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(9,2);
INSERT INTO DETALLE_PERFIL_APLICACION VALUES(10,3);
#TABLA DETALLE_APLICACION_DERECHO
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(1,1,1,1,1,1,1);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(2,2,1,1,0,0,1);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(3,3,0,0,0,1,1);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(4,4,1,0,0,0,0);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(5,5,0,1,1,1,0);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(6,6,0,0,0,0,1);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(7,7,0,1,0,1,0);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(8,1,1,1,1,1,1);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(9,2,1,1,0,0,1);
INSERT INTO DETALLE_APLICACION_DERECHO VALUES(10,3,0,0,0,1,1);

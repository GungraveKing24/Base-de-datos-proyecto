CREATE DATABASE  IF NOT EXISTS `mecare` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mecare`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: mecare
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `id_empleado` int NOT NULL AUTO_INCREMENT,
  `nombre_empleado` varchar(50) NOT NULL,
  `apellido_empleado` varchar(30) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `correoelectronico_empleado` varchar(50) NOT NULL,
  `telefono_empleado` int DEFAULT NULL,
  `administrador` tinyint NOT NULL,
  `fecharegistro_empleado` varchar(45) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`id_empleado`),
  UNIQUE KEY `nombre_usuario` (`nombre_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (1,'Gerson','Perez','gersonmp','gerson@gmail.com',78475895,0,'2023-05-31','mecareempresa0'),(2,'Esmeralda','Garcia','esmenb','esme@gmail.comm',74589247,1,'2019-07-01','mecareempresa0'),(3,'Wendy','Perez','wendypp','wendy@hotmail.com',73547851,0,'2019-07-02','mecareempresa0'),(4,'Xenia','Perez','xeniapm','xenia@gmail.com',74158747,0,'2020-05-31','mecare0'),(5,'Jorge','Francisco','jorgefran','fran@gmail.com',78452569,1,'2019-08-31','mecareempresa1'),(6,'Melanie','Giselle','melaniee','melanie@gmail.com',78874474,1,'2019-07-01','mecareempresa0'),(7,'Leslie','Pinedad','lesliep','lesliepine@hotmail.com',78415698,0,'2023-05-15','mecareempresa1'),(8,'Daniela','Alvarez','danialva','daniela@gmail.com',74589524,0,'2020-09-10','mecareempresa0'),(9,'Diego','Burgos','diego@hotmail.com','diego@hotmail.com',74528188,0,'2020-05-31','mecareempresa1'),(10,'Ana','Perez','anita','Anita@gmail.com',74851587,1,'2020-03-01','mecareempresa0');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `informesinventario`
--

DROP TABLE IF EXISTS `informesinventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `informesinventario` (
  `id_informe` int NOT NULL AUTO_INCREMENT,
  `fecha_informe` date NOT NULL,
  `descripcion_informe` varchar(300) NOT NULL,
  `id_producto_informe` int NOT NULL,
  `id_empleado_informe` int NOT NULL,
  PRIMARY KEY (`id_informe`),
  KEY `id_producto_empleado_idx` (`id_empleado_informe`),
  CONSTRAINT `id_producto_empleado` FOREIGN KEY (`id_empleado_informe`) REFERENCES `empleado` (`id_empleado`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `informesinventario`
--

LOCK TABLES `informesinventario` WRITE;
/*!40000 ALTER TABLE `informesinventario` DISABLE KEYS */;
INSERT INTO `informesinventario` VALUES (1,'2023-09-04','El producto reabastecido fue: Niacinamide Ordinary en la fecha: 3/12/2023 12:00:00 AM por el empleado: Gerson Perez',1,1),(2,'2023-09-04','El producto reabastecido fue: Acido Hyaluronico en la fecha: 3/12/2023 12:00:00 AM por el empleado: Esmeralda Garcia',2,2),(3,'2023-09-04','El producto reabastecido fue: Acido Hyaluronico en la fecha: 2/14/2020 12:00:00 AM por el empleado: Wendy Perez',3,3),(4,'2023-09-04','El producto reabastecido fue: Acido Glycolico en la fecha: 11/9/2023 12:00:00 AM por el empleado: Xenia Perez',4,4),(5,'2023-09-04','El producto reabastecido fue: AHA 30% + BHA 2% en la fecha: 3/4/2020 12:00:00 AM por el empleado: Jorge Francisco',5,5),(6,'2023-09-04','El producto reabastecido fue: Caffeine Solution en la fecha: 3/4/2020 12:00:00 AM por el empleado: Melanie Giselle',6,6),(7,'2023-09-04','El producto reabastecido fue: Pycnogenol en la fecha: 8/19/2023 12:00:00 AM por el empleado: Leslie Pinedad',7,7),(8,'2023-09-04','El producto reabastecido fue: Rosa palida en la fecha: 8/19/2023 12:00:00 AM por el empleado: Daniela Alvarez',8,8),(9,'2023-09-04','El producto reabastecido fue: Agua Micelar en la fecha: 8/19/2023 12:00:00 AM por el empleado: Diego Burgos',9,9),(10,'2023-09-04','El producto reabastecido fue: Corrector de ojos en la fecha: 7/27/2023 12:00:00 AM por el empleado: Ana Perez',10,10);
/*!40000 ALTER TABLE `informesinventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_inventario`
--

DROP TABLE IF EXISTS `movimiento_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_inventario` (
  `id_movimiento` int NOT NULL AUTO_INCREMENT,
  `fecha_movimiento` date NOT NULL,
  `cantidad_movimiento` int NOT NULL,
  `tipo_movimiento` varchar(50) NOT NULL,
  `id_productomovimiento` int NOT NULL,
  PRIMARY KEY (`id_movimiento`),
  KEY `id_producto_idx` (`id_productomovimiento`),
  CONSTRAINT `id_productomovimiento` FOREIGN KEY (`id_productomovimiento`) REFERENCES `producto` (`id_producto`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_inventario`
--

LOCK TABLES `movimiento_inventario` WRITE;
/*!40000 ALTER TABLE `movimiento_inventario` DISABLE KEYS */;
INSERT INTO `movimiento_inventario` VALUES (1,'2023-07-01',100,'VENTA',1),(2,'2023-09-01',1,'RETIRADO',1),(3,'2023-03-12',2555,'VENTA',2),(4,'2020-02-14',100,'VENTA',3),(5,'2023-04-10',2,'RETIRADO',3),(6,'2019-08-12',100,'VENTA',4),(7,'2020-03-04',50,'VENTA',5),(8,'2020-03-04',100,'VENTA',6),(9,'2023-07-27',10,'VENTA',10),(10,'2021-05-09',33,'VENTA',11),(11,'2022-11-30',255,'VENTA',12),(12,'2023-11-12',2,'RETIRADO',5),(13,'2023-09-10',1,'RETIRADO',5),(14,'2023-07-12',6,'RETIRADO',15),(15,'2020-10-05',2,'RETIRADO',12),(16,'2023-10-03',1,'RETIRADO',7),(17,'2022-01-23',1,'RETIRADO',9),(18,'2022-01-27',1,'RETIRADO',9);
/*!40000 ALTER TABLE `movimiento_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido_reposicion`
--

DROP TABLE IF EXISTS `pedido_reposicion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido_reposicion` (
  `id_pedido_reposicion` int NOT NULL AUTO_INCREMENT,
  `fecha_reposicion` date NOT NULL,
  `fecha_caducidad` date DEFAULT NULL,
  `cantidad_reposicion` int NOT NULL,
  `estadodepedido` varchar(50) NOT NULL,
  `id_productopedido` int NOT NULL,
  PRIMARY KEY (`id_pedido_reposicion`),
  KEY `id_producto_idx` (`id_productopedido`),
  CONSTRAINT `id_productopedido` FOREIGN KEY (`id_productopedido`) REFERENCES `producto` (`id_producto`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido_reposicion`
--

LOCK TABLES `pedido_reposicion` WRITE;
/*!40000 ALTER TABLE `pedido_reposicion` DISABLE KEYS */;
INSERT INTO `pedido_reposicion` VALUES (1,'2023-03-12','2023-12-20',100,'Rechazado',1),(2,'2023-03-12','2023-12-20',2555,'Rechazado',2),(3,'2020-02-14','2023-12-20',100,'Aceptado',3),(4,'2019-08-12','2023-12-20',30,'Rechazado',4),(5,'2019-08-12','2023-12-20',100,'Aceptado',4),(6,'2020-03-04','2023-12-20',50,'Aceptado',5),(7,'2023-08-19','2023-12-20',20,'Rechazado',5),(8,'2020-03-04','2023-12-20',15,'Aceptado',6),(9,'2023-08-19','2023-12-20',20,'Rechazado',7),(10,'2020-03-04','2023-12-20',15,'Aceptado',6),(11,'2023-08-19','2023-12-20',1,'Rechazado',8),(12,'2022-09-10','2023-12-20',50,'Rechazado',9),(13,'2023-08-19','2023-12-20',2,'Rechazado',9),(14,'2023-07-27','2023-12-20',10,'Aceptado',10),(15,'2021-05-09','2023-12-20',33,'Aceptado',11),(16,'2022-11-30','2023-12-20',255,'Aceptado',12),(18,'2023-08-29','2023-12-20',100,'Rechazado',14),(19,'2023-08-29','2023-12-20',50,'Rechazado',15),(20,'2023-08-29','2023-12-20',75,'Rechazado',10),(21,'2023-11-09','2023-11-09',20,'Pendiente',3);
/*!40000 ALTER TABLE `pedido_reposicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `nombre_producto` varchar(50) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  `precio_entrada` double NOT NULL,
  `precio_salida` double NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `id_proveedorproducto` int NOT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `id_proveedor_idx` (`id_proveedorproducto`),
  CONSTRAINT `id_proveedorproducto` FOREIGN KEY (`id_proveedorproducto`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Niacinamide_Ordinary','Arrugas',10.5,16.5,'2023-07-01','Serum',1),(2,'Acido Hyaluronico','Arrugas',20,25,'2023-06-01','Serum',1),(3,'Acido Hyaluronico','Arrugas',15,20,'2023-06-01','Crema',1),(4,'Acido Glycolico','Puntos Negros',35,39,'2023-08-01','Serum',3),(5,'AHA 30% + BHA 2% ','Exfoliante',22.25,25.5,'2023-06-01','Serum',3),(6,'Caffeine Solution ','Puntos Negros',15.5,25.5,'2023-06-01','Serum',3),(7,'Pycnogenol ','Puntos Negros',20.5,25.5,'2023-07-03','Serum',10),(8,'Rosa palida','Labial',5,8.5,'2020-07-03','Lapiz',6),(9,'Agua Micelar ','Limpieza',20.5,24,'2021-12-23','Liquido',7),(10,'Corrector de ojos ','Maquillaje',3.5,5.5,'2022-05-03','Lapiz',4),(11,'Blue Label ','Perfume',18.5,20.75,'2019-07-03','Liquido',2),(12,'Desodorante','Perfume',17.5,18.75,'2020-09-30','Liquido',8),(14,'Blue  ','Desodorante',18.5,20.75,'2010-07-03','Liquido',2),(15,'Pycnogenol Gel','Puntos Negros',22.5,29.5,'2023-07-03','Serum',10);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `id_proveedor` int NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` varchar(50) NOT NULL,
  `telefono_proveedor` varchar(45) NOT NULL,
  `correoelectronico_proveedor` varchar(50) DEFAULT NULL,
  `ciudad_proveedor` varchar(50) NOT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'Ordinary','50324456789','ordinary@empresa.com','San Salvador'),(2,'Scent','50324567890','thescent@empresaonline.com','San Miguel'),(3,'La roche posay','50379981234','rocheposay@psay.emp.com','San Salvador'),(4,'Chanel','50324567890','chanel@chanel.com','San Salvador'),(5,'Shepora','50324561111','shepora@.hotmail.com','La Libertad'),(6,'Dior','50324415678','dior@dior.com','Cabañas'),(7,'Loreal','50324245678','loreal@realempresa.com','San Salvador'),(8,'Nivea','50377090977','nivea02@nivea.com','Santa Tecla'),(9,'Ssu','50378567809','susu@cat.com','Santa Ana'),(10,'Intel','50324456795','intel@intel.com','Santa Ana');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock`
--

DROP TABLE IF EXISTS `stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stock` (
  `id_stock` int NOT NULL AUTO_INCREMENT,
  `cantidadstock` int NOT NULL,
  `fecha_stock` date NOT NULL,
  `id_productostock` int NOT NULL,
  PRIMARY KEY (`id_stock`),
  KEY `id_producto_idx` (`id_productostock`),
  CONSTRAINT `id_productostock` FOREIGN KEY (`id_productostock`) REFERENCES `producto` (`id_producto`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock`
--

LOCK TABLES `stock` WRITE;
/*!40000 ALTER TABLE `stock` DISABLE KEYS */;
INSERT INTO `stock` VALUES (1,10,'2023-07-01',1),(2,5,'2023-06-01',2),(3,6,'2023-06-01',3),(4,8,'2023-08-01',4),(5,5,'2023-06-01',5),(6,35,'2023-06-01',6),(7,12,'2023-07-03',7),(8,15,'2023-06-01',8),(9,15,'2023-06-28',9),(10,30,'2023-07-08',10),(11,15,'2019-07-03',11),(12,21,'2020-09-30',12),(14,31,'2010-07-03',14),(15,14,'2023-07-03',15);
/*!40000 ALTER TABLE `stock` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-12 18:47:57

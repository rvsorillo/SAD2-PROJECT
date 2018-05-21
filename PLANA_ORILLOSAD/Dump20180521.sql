CREATE DATABASE  IF NOT EXISTS `mltp_shop` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `mltp_shop`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: mltp_shop
-- ------------------------------------------------------
-- Server version	5.7.17-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `cust_id` int(11) NOT NULL AUTO_INCREMENT,
  `cust_fname` varchar(45) NOT NULL,
  `cust_lname` varchar(45) NOT NULL,
  `cust_contact` varchar(11) NOT NULL,
  `cust_address` varchar(120) NOT NULL,
  `company_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cust_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Rona Melissa','Plana','09121831313','Davao city',NULL),(2,'Yleona','Camelotes','09132183123','Davao',NULL);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_type`
--

DROP TABLE IF EXISTS `customer_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer_type` (
  `cust_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `cust_type` varchar(45) NOT NULL,
  PRIMARY KEY (`cust_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_type`
--

LOCK TABLES `customer_type` WRITE;
/*!40000 ALTER TABLE `customer_type` DISABLE KEYS */;
INSERT INTO `customer_type` VALUES (1,'Walk-in'),(2,'Regular');
/*!40000 ALTER TABLE `customer_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `emp_id` int(11) NOT NULL AUTO_INCREMENT,
  `emp_fname` varchar(45) DEFAULT NULL,
  `emp_lname` varchar(45) DEFAULT NULL,
  `emp_contact` varchar(11) DEFAULT NULL,
  `emp_address` varchar(120) DEFAULT NULL,
  `emp_bday` date DEFAULT NULL,
  `emp_username` varchar(45) DEFAULT NULL,
  `emp_password` varchar(45) DEFAULT NULL,
  `emp_type_id_fk` int(11) NOT NULL,
  `emp_skills` varchar(255) DEFAULT NULL,
  `emp_status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`emp_id`),
  KEY `emp_type_id_fk_idx` (`emp_type_id_fk`),
  CONSTRAINT `emp_type_id_fk` FOREIGN KEY (`emp_type_id_fk`) REFERENCES `employee_type` (`emp_type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Maria Luisa','Plana','09101471873','Davao city','1980-11-23','admin','admin',1,'','Active'),(2,'Tian ','Ong','0932372832','Davao city','1989-10-19','','',3,'Trucks','Inactive');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_type`
--

DROP TABLE IF EXISTS `employee_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee_type` (
  `emp_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `emp_type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`emp_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_type`
--

LOCK TABLES `employee_type` WRITE;
/*!40000 ALTER TABLE `employee_type` DISABLE KEYS */;
INSERT INTO `employee_type` VALUES (1,'Admin'),(2,'Welder'),(3,'Driver'),(4,'Mechanic');
/*!40000 ALTER TABLE `employee_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fetch_inventory`
--

DROP TABLE IF EXISTS `fetch_inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fetch_inventory` (
  `fetch_itemid` int(11) DEFAULT NULL,
  `fetch_itemname` varchar(45) DEFAULT NULL,
  `fetch_price` int(11) DEFAULT NULL,
  `fetch_itemqty` int(11) DEFAULT NULL,
  `fetch_brand` varchar(45) DEFAULT NULL,
  `fetch_measurement` varchar(45) DEFAULT NULL,
  `fetch_servid` int(11) DEFAULT NULL,
  `fetch_itemtype` int(11) DEFAULT NULL,
  `fetch_supp` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fetch_inventory`
--

LOCK TABLES `fetch_inventory` WRITE;
/*!40000 ALTER TABLE `fetch_inventory` DISABLE KEYS */;
/*!40000 ALTER TABLE `fetch_inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fetch_temp`
--

DROP TABLE IF EXISTS `fetch_temp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fetch_temp` (
  `temp_name` varchar(45) DEFAULT NULL,
  `temp_price` varchar(45) DEFAULT NULL,
  `temp_qty` varchar(45) DEFAULT NULL,
  `temp_subtotal` varchar(45) DEFAULT NULL,
  `temp_serviceid` varchar(45) DEFAULT NULL,
  `temp_itemid` varchar(45) DEFAULT NULL,
  `temp_type` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fetch_temp`
--

LOCK TABLES `fetch_temp` WRITE;
/*!40000 ALTER TABLE `fetch_temp` DISABLE KEYS */;
/*!40000 ALTER TABLE `fetch_temp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory` (
  `item_id_inventory_fk` int(11) NOT NULL,
  `inventory_quantity` int(11) NOT NULL,
  PRIMARY KEY (`item_id_inventory_fk`),
  KEY `item_id_idx` (`item_id_inventory_fk`),
  CONSTRAINT `item_id_inventory_fk` FOREIGN KEY (`item_id_inventory_fk`) REFERENCES `item` (`item_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,14),(2,36);
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(45) DEFAULT NULL,
  `item_measurement` varchar(45) DEFAULT NULL,
  `item_type_id_fk` int(11) NOT NULL,
  `item_purchase_price` int(11) DEFAULT NULL,
  `item_selling_price` int(11) DEFAULT NULL,
  `supplier_id_item_fk` int(11) NOT NULL,
  `item_brand` varchar(45) DEFAULT NULL,
  `item_size` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`item_id`),
  KEY `item_type_id_idx` (`item_type_id_fk`),
  KEY `supplier_id_idx` (`supplier_id_item_fk`),
  CONSTRAINT `item_type_id_fk` FOREIGN KEY (`item_type_id_fk`) REFERENCES `item_type` (`item_type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `supplier_id_item_fk` FOREIGN KEY (`supplier_id_item_fk`) REFERENCES `supplier` (`supplier_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
INSERT INTO `item` VALUES (1,'Tire','Piece',1,200,300,1,'Gulf','10 inches'),(2,'Gear Oil','Milliliter',2,40,50,1,'Gulf','250ml');
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_type`
--

DROP TABLE IF EXISTS `item_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item_type` (
  `item_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_type` varchar(45) NOT NULL,
  PRIMARY KEY (`item_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_type`
--

LOCK TABLES `item_type` WRITE;
/*!40000 ALTER TABLE `item_type` DISABLE KEYS */;
INSERT INTO `item_type` VALUES (1,'Part'),(2,'Consumable');
/*!40000 ALTER TABLE `item_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `job_order`
--

DROP TABLE IF EXISTS `job_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `job_order` (
  `job_order_id` int(11) NOT NULL AUTO_INCREMENT,
  `plate_number_fk` varchar(11) NOT NULL,
  `problem_reported` varchar(255) DEFAULT NULL,
  `initial_diagnosis` varchar(255) DEFAULT NULL,
  `req_check_out` datetime DEFAULT NULL,
  `check_in` datetime NOT NULL,
  `check_out` datetime DEFAULT NULL,
  `status_type_id_fk` int(11) NOT NULL,
  `total_amount` int(11) DEFAULT NULL,
  PRIMARY KEY (`job_order_id`),
  KEY `status_type_id_fk_idx` (`status_type_id_fk`),
  KEY `plate_number_fk_idx` (`plate_number_fk`),
  CONSTRAINT `plate_number_fk` FOREIGN KEY (`plate_number_fk`) REFERENCES `vehicle` (`plate_number`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `status_type_id_fk` FOREIGN KEY (`status_type_id_fk`) REFERENCES `status_type` (`status_type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `job_order`
--

LOCK TABLES `job_order` WRITE;
/*!40000 ALTER TABLE `job_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `job_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `job_order_items`
--

DROP TABLE IF EXISTS `job_order_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `job_order_items` (
  `job_order_items_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id_job_order_fk` int(11) DEFAULT NULL,
  `job_order_items_quantity` int(11) DEFAULT NULL,
  `job_order_services_id_fk` int(11) DEFAULT NULL,
  `total_job_order_items` double DEFAULT NULL,
  PRIMARY KEY (`job_order_items_id`),
  KEY `item_id_job_order_fk_idx` (`item_id_job_order_fk`),
  KEY `job_order_services_fk_idx` (`job_order_services_id_fk`),
  CONSTRAINT `item_id_job_order_fk` FOREIGN KEY (`item_id_job_order_fk`) REFERENCES `item` (`item_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `job_order_services_fk` FOREIGN KEY (`job_order_services_id_fk`) REFERENCES `job_order_services` (`job_order_services_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `job_order_items`
--

LOCK TABLES `job_order_items` WRITE;
/*!40000 ALTER TABLE `job_order_items` DISABLE KEYS */;
/*!40000 ALTER TABLE `job_order_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `job_order_payment`
--

DROP TABLE IF EXISTS `job_order_payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `job_order_payment` (
  `job_order_payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `jp_job_order_id` int(11) DEFAULT NULL,
  `amount_paid` double DEFAULT NULL,
  `balance` double DEFAULT NULL,
  `date_payment` datetime DEFAULT NULL,
  PRIMARY KEY (`job_order_payment_id`),
  KEY `jp_job_order_id_idx` (`jp_job_order_id`),
  KEY `jp_job_order_id` (`jp_job_order_id`),
  CONSTRAINT `jp_job_order_id` FOREIGN KEY (`jp_job_order_id`) REFERENCES `job_order` (`job_order_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `job_order_payment`
--

LOCK TABLES `job_order_payment` WRITE;
/*!40000 ALTER TABLE `job_order_payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `job_order_payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `job_order_services`
--

DROP TABLE IF EXISTS `job_order_services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `job_order_services` (
  `job_order_services_id` int(11) NOT NULL AUTO_INCREMENT,
  `service_type_job_order_fk` int(11) NOT NULL,
  `service_fee` int(11) DEFAULT NULL,
  `emp_id_job_order_fk` int(11) DEFAULT NULL,
  `labor_fee` int(11) DEFAULT NULL,
  `job_order_id_serv_fk` int(11) DEFAULT NULL,
  `time_started_serv` datetime DEFAULT NULL,
  `time_ended_serv` datetime DEFAULT NULL,
  `subtotal_job_order` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`job_order_services_id`),
  UNIQUE KEY `job_order_services_id_UNIQUE` (`job_order_services_id`),
  KEY `service_type_job_order_fk_idx` (`service_type_job_order_fk`),
  KEY `emp_id_job_order_fk_idx` (`emp_id_job_order_fk`),
  KEY `job_order_id_serv_fk_idx` (`job_order_id_serv_fk`),
  CONSTRAINT `emp_id_job_order_fk` FOREIGN KEY (`emp_id_job_order_fk`) REFERENCES `employee` (`emp_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `job_order_id_serv_fk` FOREIGN KEY (`job_order_id_serv_fk`) REFERENCES `job_order` (`job_order_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `service_type_job_order_fk` FOREIGN KEY (`service_type_job_order_fk`) REFERENCES `service` (`service_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `job_order_services`
--

LOCK TABLES `job_order_services` WRITE;
/*!40000 ALTER TABLE `job_order_services` DISABLE KEYS */;
/*!40000 ALTER TABLE `job_order_services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_order`
--

DROP TABLE IF EXISTS `purchase_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchase_order` (
  `purch_order_id` int(11) NOT NULL AUTO_INCREMENT,
  `purch_order_date` date DEFAULT NULL,
  `purch_suppid` int(11) DEFAULT NULL,
  `purch_status` varchar(45) DEFAULT NULL,
  `purch_total` int(11) DEFAULT NULL,
  PRIMARY KEY (`purch_order_id`),
  KEY `purch_suppid_idx` (`purch_suppid`),
  CONSTRAINT `purch_suppid` FOREIGN KEY (`purch_suppid`) REFERENCES `supplier` (`supplier_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_order`
--

LOCK TABLES `purchase_order` WRITE;
/*!40000 ALTER TABLE `purchase_order` DISABLE KEYS */;
INSERT INTO `purchase_order` VALUES (1,'2018-04-02',1,'Complete',6000),(2,'2018-05-19',1,'Pending',4800);
/*!40000 ALTER TABLE `purchase_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_order_details`
--

DROP TABLE IF EXISTS `purchase_order_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchase_order_details` (
  `purch_details_id` int(11) NOT NULL AUTO_INCREMENT,
  `purch_itemid` int(11) DEFAULT NULL,
  `purch_itemqty` int(11) DEFAULT NULL,
  `purch_dstatus` varchar(45) DEFAULT NULL,
  `purch_purchid` int(11) DEFAULT NULL,
  `purch_finalitemqty` int(11) DEFAULT NULL,
  `purch_reqemployeeid` int(11) DEFAULT NULL,
  PRIMARY KEY (`purch_details_id`),
  KEY `purch_purchid_idx` (`purch_purchid`),
  KEY `purch_reqemployeeid_idx` (`purch_reqemployeeid`),
  KEY `purch_itemid_idx` (`purch_itemid`),
  CONSTRAINT `purch_itemid` FOREIGN KEY (`purch_itemid`) REFERENCES `item` (`item_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `purch_purchid` FOREIGN KEY (`purch_purchid`) REFERENCES `purchase_order` (`purch_order_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `purch_reqemployeeid` FOREIGN KEY (`purch_reqemployeeid`) REFERENCES `employee` (`emp_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_order_details`
--

LOCK TABLES `purchase_order_details` WRITE;
/*!40000 ALTER TABLE `purchase_order_details` DISABLE KEYS */;
INSERT INTO `purchase_order_details` VALUES (1,1,0,'Complete',1,30,1),(2,2,0,'Complete',2,20,2),(3,1,20,'Incomplete',2,20,2);
/*!40000 ALTER TABLE `purchase_order_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service`
--

DROP TABLE IF EXISTS `service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `service` (
  `service_id` int(11) NOT NULL AUTO_INCREMENT,
  `service_type` varchar(45) NOT NULL,
  PRIMARY KEY (`service_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service`
--

LOCK TABLES `service` WRITE;
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` VALUES (1,'Change Tires');
/*!40000 ALTER TABLE `service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service_details`
--

DROP TABLE IF EXISTS `service_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `service_details` (
  `service_details_id` int(11) NOT NULL AUTO_INCREMENT,
  `service_type_fk_details` int(11) DEFAULT NULL,
  `item_id_service_fk` int(11) DEFAULT NULL,
  PRIMARY KEY (`service_details_id`),
  KEY `item_id_service_fk_idx` (`item_id_service_fk`),
  KEY `service_type_fk_details_idx` (`service_type_fk_details`),
  CONSTRAINT `item_id_service_fk` FOREIGN KEY (`item_id_service_fk`) REFERENCES `item` (`item_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `service_type_fk_details` FOREIGN KEY (`service_type_fk_details`) REFERENCES `service` (`service_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service_details`
--

LOCK TABLES `service_details` WRITE;
/*!40000 ALTER TABLE `service_details` DISABLE KEYS */;
INSERT INTO `service_details` VALUES (1,1,1),(2,1,2);
/*!40000 ALTER TABLE `service_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status_type`
--

DROP TABLE IF EXISTS `status_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `status_type` (
  `status_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `status_type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`status_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_type`
--

LOCK TABLES `status_type` WRITE;
/*!40000 ALTER TABLE `status_type` DISABLE KEYS */;
INSERT INTO `status_type` VALUES (1,'Past Deadline'),(2,'On Progress'),(3,'Finished'),(4,'Released');
/*!40000 ALTER TABLE `status_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock_in`
--

DROP TABLE IF EXISTS `stock_in`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stock_in` (
  `stock_in_id` int(11) NOT NULL AUTO_INCREMENT,
  `stock_in_date` date NOT NULL,
  `delivery_date` date NOT NULL,
  PRIMARY KEY (`stock_in_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_in`
--

LOCK TABLES `stock_in` WRITE;
/*!40000 ALTER TABLE `stock_in` DISABLE KEYS */;
INSERT INTO `stock_in` VALUES (1,'2018-04-02','2018-04-02'),(2,'2018-05-19','2018-05-19');
/*!40000 ALTER TABLE `stock_in` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock_in_details`
--

DROP TABLE IF EXISTS `stock_in_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stock_in_details` (
  `stock_in_details_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id_stock_in_fk` int(11) NOT NULL,
  `stock_in_quantity` int(11) NOT NULL,
  `stock_in_id_fk` int(11) NOT NULL,
  PRIMARY KEY (`stock_in_details_id`),
  KEY `stoc_in_id_idx` (`stock_in_id_fk`),
  KEY `item_id_stock_in_fk_idx` (`item_id_stock_in_fk`),
  CONSTRAINT `item_id_stock_in_fk` FOREIGN KEY (`item_id_stock_in_fk`) REFERENCES `item` (`item_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stock_in_id_fk` FOREIGN KEY (`stock_in_id_fk`) REFERENCES `stock_in` (`stock_in_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_in_details`
--

LOCK TABLES `stock_in_details` WRITE;
/*!40000 ALTER TABLE `stock_in_details` DISABLE KEYS */;
INSERT INTO `stock_in_details` VALUES (1,1,20,1),(2,1,10,2),(3,2,20,2),(4,1,10,2),(5,2,20,2);
/*!40000 ALTER TABLE `stock_in_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock_order`
--

DROP TABLE IF EXISTS `stock_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stock_order` (
  `stock_order_id` int(11) NOT NULL AUTO_INCREMENT,
  `cust_id_stock_order_fk` int(11) NOT NULL,
  `stock_order_date` datetime NOT NULL,
  `cust_type_id_fk` int(11) DEFAULT NULL,
  `total_amount_stock_order` double DEFAULT NULL,
  PRIMARY KEY (`stock_order_id`),
  KEY `cust_id_idx` (`cust_id_stock_order_fk`),
  KEY `cust_type_id_fk_idx` (`cust_type_id_fk`),
  CONSTRAINT `cust_id_stock_order_fk` FOREIGN KEY (`cust_id_stock_order_fk`) REFERENCES `customer` (`cust_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `cust_type_id_fk` FOREIGN KEY (`cust_type_id_fk`) REFERENCES `customer_type` (`cust_type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_order`
--

LOCK TABLES `stock_order` WRITE;
/*!40000 ALTER TABLE `stock_order` DISABLE KEYS */;
INSERT INTO `stock_order` VALUES (1,1,'2018-04-02 21:45:20',NULL,1200),(2,1,'2018-05-19 16:59:52',NULL,6000),(3,2,'2018-05-19 17:12:39',NULL,100);
/*!40000 ALTER TABLE `stock_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock_order_details`
--

DROP TABLE IF EXISTS `stock_order_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stock_order_details` (
  `stock_order_details_id` int(11) NOT NULL AUTO_INCREMENT,
  `stock_order_item_quantity` int(11) NOT NULL,
  `stock_order_id_fk` int(11) DEFAULT NULL,
  `job_order_id_stock_order_fk` int(11) DEFAULT NULL,
  `item_id_stock_order_fk` int(11) NOT NULL,
  `total_stock_order_details` double DEFAULT NULL,
  PRIMARY KEY (`stock_order_details_id`),
  KEY `stock_order_id_idx` (`stock_order_id_fk`),
  KEY `job_order_id_stock_order_fk_idx` (`job_order_id_stock_order_fk`),
  KEY `item_id_stock_order_fk_idx` (`item_id_stock_order_fk`),
  CONSTRAINT `item_id_stock_order_fk` FOREIGN KEY (`item_id_stock_order_fk`) REFERENCES `item` (`item_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `job_order_id_stock_order_fk` FOREIGN KEY (`job_order_id_stock_order_fk`) REFERENCES `job_order` (`job_order_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stock_order_id_fk` FOREIGN KEY (`stock_order_id_fk`) REFERENCES `stock_order` (`stock_order_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_order_details`
--

LOCK TABLES `stock_order_details` WRITE;
/*!40000 ALTER TABLE `stock_order_details` DISABLE KEYS */;
INSERT INTO `stock_order_details` VALUES (1,4,1,NULL,1,1200),(2,20,2,NULL,1,6000),(3,2,3,NULL,2,100),(4,2,NULL,1,2,100);
/*!40000 ALTER TABLE `stock_order_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock_out`
--

DROP TABLE IF EXISTS `stock_out`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stock_out` (
  `stock_out_id` int(11) NOT NULL AUTO_INCREMENT,
  `stock_out_date` datetime DEFAULT NULL,
  PRIMARY KEY (`stock_out_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_out`
--

LOCK TABLES `stock_out` WRITE;
/*!40000 ALTER TABLE `stock_out` DISABLE KEYS */;
/*!40000 ALTER TABLE `stock_out` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock_out_details`
--

DROP TABLE IF EXISTS `stock_out_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stock_out_details` (
  `stock_out_details_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id_stock_out_fk` int(11) DEFAULT NULL,
  `stock_out_quantity` int(11) DEFAULT NULL,
  `stock_out_id_fk` int(11) DEFAULT NULL,
  `stock_out_type` varchar(45) DEFAULT NULL,
  `job_order_id_stock_out_fk` int(11) DEFAULT NULL,
  `total_stock_out_details` int(11) DEFAULT NULL,
  PRIMARY KEY (`stock_out_details_id`),
  KEY `item_id_stock_out_fk_idx` (`item_id_stock_out_fk`),
  KEY `stock_out_id_fk_idx` (`stock_out_id_fk`),
  KEY `job_order_id_stock_out_fk_idx` (`job_order_id_stock_out_fk`),
  CONSTRAINT `item_id_stock_out_fk` FOREIGN KEY (`item_id_stock_out_fk`) REFERENCES `item` (`item_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `job_order_id_stock_out_fk` FOREIGN KEY (`job_order_id_stock_out_fk`) REFERENCES `job_order` (`job_order_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stock_out_id_fk` FOREIGN KEY (`stock_out_id_fk`) REFERENCES `stock_out` (`stock_out_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_out_details`
--

LOCK TABLES `stock_out_details` WRITE;
/*!40000 ALTER TABLE `stock_out_details` DISABLE KEYS */;
INSERT INTO `stock_out_details` VALUES (1,1,4,NULL,'Sales',NULL,NULL),(2,1,20,NULL,'Sales',NULL,NULL),(3,2,2,NULL,'Sales',NULL,NULL),(4,2,2,NULL,NULL,1,100);
/*!40000 ALTER TABLE `stock_out_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `supplier` (
  `supplier_id` int(11) NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(45) DEFAULT NULL,
  `supplier_contact_person` varchar(45) DEFAULT NULL,
  `supplier_contact` varchar(11) DEFAULT NULL,
  `supplier_address` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'Five Star','Duey Guevarra','09121831321','Davao');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle` (
  `plate_number` varchar(11) NOT NULL,
  `cust_id_vehicle_fk` int(11) NOT NULL,
  `vehicle_type_fk` int(11) DEFAULT NULL,
  `vehicle_make` varchar(45) DEFAULT NULL,
  `vehicle_model` varchar(45) DEFAULT NULL,
  `vehicle_year` int(11) DEFAULT NULL,
  PRIMARY KEY (`plate_number`),
  KEY `cust_id_vehicle_fk_idx` (`cust_id_vehicle_fk`),
  KEY `vehicle_type_fk_idx` (`vehicle_type_fk`),
  CONSTRAINT `cust_id_vehicle_fk` FOREIGN KEY (`cust_id_vehicle_fk`) REFERENCES `customer` (`cust_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `vehicle_type_fk` FOREIGN KEY (`vehicle_type_fk`) REFERENCES `vehicle_type` (`vehicle_type_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES ('DAUI23',2,5,'Nissan','Navara',2001),('HDUA234',1,5,'Ford','Ranger',NULL);
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_type`
--

DROP TABLE IF EXISTS `vehicle_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle_type` (
  `vehicle_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `vehicle_category` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`vehicle_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_type`
--

LOCK TABLES `vehicle_type` WRITE;
/*!40000 ALTER TABLE `vehicle_type` DISABLE KEYS */;
INSERT INTO `vehicle_type` VALUES (1,'Sedan'),(2,'SUV'),(3,'Hatchback'),(4,'Coupe'),(5,'Pickup'),(6,'Van'),(7,'Bus'),(8,'6-Wheeler'),(9,'8-Wheeler'),(10,'10-Wheeler'),(11,'12-Wheeler'),(12,'18-Wheeler');
/*!40000 ALTER TABLE `vehicle_type` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-05-21 17:28:48

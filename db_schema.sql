CREATE TABLE `tbl_customer` (
  `cusid` int(11) NOT NULL AUTO_INCREMENT,
  `cus_fname` varchar(100) DEFAULT NULL,
  `cus_lname` varchar(100) DEFAULT NULL,
  `cus_phoneno` varchar(45) DEFAULT NULL,
  `cus_email` varchar(45) DEFAULT NULL,
  `cus_password` varchar(45) DEFAULT NULL,
  `active` binary(1) DEFAULT '1',
  PRIMARY KEY (`cusid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

<!-------------------------------------------------------------------------->
CREATE TABLE `rideshare`.`tbl_driver` (
  `dri_id` INT NOT NULL AUTO_INCREMENT,
  `dri_fname` VARCHAR(45) NULL,
  `dri_lname` VARCHAR(45) NULL,
  `dri_address` VARCHAR(100) NULL,
  `dri_licence` VARCHAR(10) NULL,
  `dri_nic` VARCHAR(10) NULL,
  `dri_password` VARCHAR(45) NULL,
  `active` BINARY NULL DEFAULT 1,
  PRIMARY KEY (`dri_id`));
<!---------------------------------------------------------------------------->
CREATE TABLE `tbl_vehicle` (
  `veh_id` int(11) NOT NULL AUTO_INCREMENT,
  `veh_regno` varchar(45) DEFAULT NULL,
  `veh_type` varchar(45) DEFAULT NULL,
  `veh_description` varchar(45) DEFAULT NULL,
  `veh_location` varchar(45) DEFAULT NULL,
  `veh_driverid` varchar(45) DEFAULT NULL,
  `veh_custrequest` varchar(45) DEFAULT NULL,
  `active` binary(1) DEFAULT '1',
  PRIMARY KEY (`veh_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

  
 <!------------------------------------------------------------------------------->
 CREATE TABLE `rideshare`.`tbl_booking` (
  `bk_id` INT NOT NULL AUTO_INCREMENT,
  `bk_time` DATETIME NULL,
  `bk_status` VARCHAR(45) NULL,
  `bk_cusid` VARCHAR(45) NULL,
  `bk_driverid` VARCHAR(45) NULL,
  `bk_startloc` VARCHAR(45) NULL,
  `bk_endloc` VARCHAR(45) NULL,
  `active` BINARY NULL DEFAULT 1,
  PRIMARY KEY (`bk_id`));

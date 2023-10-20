CREATE TABLE
    weatherstation (
        id SERIAL Primary KEY,
        name VARCHAR(100) NOT NULL,
        altitude REAL,
        longitude REAL,
        latitude REAL,
        station_type VARCHAR(100)
    );

CREATE TABLE 
     weatherdetection(
        id SERIAL Primary Key,
        weather_station_id INTEGER ,
        detection_type SMALLINT,
        value REAL,
        date DATE,
        CONSTRAINT fk_weatherstation
      FOREIGN KEY(weather_station_id) 
	  REFERENCES weatherstation(id)

     );
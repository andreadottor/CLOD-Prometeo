CREATE TABLE
    weatherstation (
        id SERIAL Primary KEY,
        name VARCHAR(100) NOT NULL,
        altitude REAL,
        longitude REAL,
        latitude REAL,
        station_type VARCHAR(100)
    );
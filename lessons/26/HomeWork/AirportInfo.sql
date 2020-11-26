create table DepartureBoard(
    FlightNumber int not null,
    DCountry varchar(64) not null,
    DCity varchar(64) not null,
    ACountry varchar(64) not null,
    ACity varchar(64) not null,
    DDate datetimeoffset not null,
    ADate datetimeoffset not null,
    FlightTime time not null,
    Airline varchar(64) not null,
    AirplaneModel varchar(32) not null
)

insert into DepartureBoard(
    FlightNumber,
    DCountry,
    DCity,
    ACountry,
    ACity,
    DDate,
    ADate,
    FlightTime,
    Airline,
    AirplaneModel
)
values
(42, 'Англия', 'Лондон', 'Россия', 'Москва', '2021-01-01 11:44:00 +03:00', '2021-01-13 14:35:00 +08:00', '19:55:00', 'Аэрофлот', 'А04032'),
(313, 'Германия', 'Берлин', 'Россия', 'Москва', '2021-01-01 07:00:00 +03:00', '2021-02-14 10:40:00 +03:00', '01:40:00', 'Аэрофлот', 'И42323')

select * from DepartureBoard

drop table DepartureBoard
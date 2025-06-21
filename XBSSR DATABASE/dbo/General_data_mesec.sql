CREATE TABLE [dbo].[General_data_mesec] (
    [mesec]                          INT             NULL,
    [supplier_total_bill]            DECIMAL (18, 4) NULL,
    [supplier_low_tariff_kwh]        DECIMAL (18, 4) NULL,
    [supplier_high_tariff_kwh]       DECIMAL (18, 4) NULL,
    [lost_electricity_low_tariff]    DECIMAL (18, 4) NULL,
    [lost_electricity_high_tariff]   DECIMAL (18, 4) NULL,
    [warm_water_maintaining_fee]     DECIMAL (18, 4) NULL,
    [hidrokit_users]                 DECIMAL (18, 4) NULL,
    [hidrokit_low_tariff_kwh]        DECIMAL (18, 4) NULL,
    [hidrokit_high_tariff_kwh]       DECIMAL (18, 4) NULL,
    [total_warm_water_consumed]      DECIMAL (18, 4) NULL,
    [indoors_low_tariff_min]         DECIMAL (18, 4) NULL,
    [indoors_low_tariff_total_min]   DECIMAL (18, 4) NULL,
    [indoors_high_tariff_min]        DECIMAL (18, 4) NULL,
    [indoors_high_tariff_total_min]  DECIMAL (18, 4) NULL,
    [warm_water_total_cost]          DECIMAL (18, 4) NULL,
    [warm_water_heating_total_price] DECIMAL (18, 4) NULL,
    [warm_water_price]               DECIMAL (18, 4) NULL,
    [indoors_total_price]            DECIMAL (18, 4) NULL,
    [Godina]                         INT             NULL
);


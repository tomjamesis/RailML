CREATE TABLE [dbo].[TManufacturer]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TManufacturerId]		BIGINT			NOT NULL,
	[ManufacturerName]		NVARCHAR(MAX)	NOT NULL,
	[VehicleManufacturerRef]	NVARCHAR(MAX)	NOT NULL,
	[ManufacturerType]		NVARCHAR(MAX)	NOT NULL,
	[SerialNumber]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TManufacturerId] PRIMARY KEY CLUSTERED ([TManufacturerId] ASC)
);

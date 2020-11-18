CREATE TABLE [dbo].[EVehicles]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EVehiclesId]	BIGINT		NOT NULL,
	[Vehicle]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EVehiclesId] PRIMARY KEY CLUSTERED ([EVehiclesId] ASC),
	CONSTRAINT [FK_EVehicles_EVehicle] FOREIGN KEY ([Vehicle]) REFERENCES [dbo].[EVehicle] ([EVehicleId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

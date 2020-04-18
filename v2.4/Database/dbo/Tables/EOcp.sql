CREATE TABLE [dbo].[EOcp]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOcpId]		SMALLINT		NOT NULL,
	[PropOperational]	SMALLINT		NOT NULL,
	[PropService]	BIGINT		NOT NULL,
	[PropEquipment]BIGINT		NOT NULL,
	[PropOther]	SMALLINT		NOT NULL,
	[Tsi]			BIGINT		NOT NULL,
	[Area]			BIGINT		NOT NULL,
	[GeoCoord]		BIGINT		NOT NULL,
	[Designator]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EOcpId] PRIMARY KEY CLUSTERED ([EOcpId] ASC),
	CONSTRAINT [FK_EOcp_TDesignator] FOREIGN KEY ([Designator]) REFERENCES [dbo].[TDesignator] ([TDesignatorId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcp_EOcpPropOperational] FOREIGN KEY ([PropOperational]) REFERENCES [dbo].[EOcpPropOperational] ([EOcpPropOperationalId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcp_TOcpPropService] FOREIGN KEY ([PropService]) REFERENCES [dbo].[TOcpPropService] ([TOcpPropServiceId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcp_EOcpPropEquipment] FOREIGN KEY ([PropEquipment]) REFERENCES [dbo].[EOcpPropEquipment] ([EOcpPropEquipmentId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcp_EOcpPropOther] FOREIGN KEY ([PropOther]) REFERENCES [dbo].[EOcpPropOther] ([EOcpPropOtherId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcp_TOcpTsi] FOREIGN KEY ([Tsi]) REFERENCES [dbo].[TOcpTsi] ([TOcpTsiId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcp_TOcpArea] FOREIGN KEY ([Area]) REFERENCES [dbo].[TOcpArea] ([TOcpAreaId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcp_TGeoCoord] FOREIGN KEY ([GeoCoord]) REFERENCES [dbo].[TGeoCoord] ([TGeoCoordId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

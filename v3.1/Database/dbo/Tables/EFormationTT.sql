CREATE TABLE [dbo].[EFormationTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EFormationTTId]SMALLINT		NOT NULL,
	[EquipmentUsage]BIGINT		NOT NULL,
	[PassengerUsage]BIGINT		NOT NULL,
	[ReservationInfo]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EFormationTTId] PRIMARY KEY CLUSTERED ([EFormationTTId] ASC),
	CONSTRAINT [FK_EFormationTT_EEquipmentUsage] FOREIGN KEY ([EquipmentUsage]) REFERENCES [dbo].[EEquipmentUsage] ([EEquipmentUsageId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormationTT_EPassengerFacilityTT] FOREIGN KEY ([PassengerUsage]) REFERENCES [dbo].[EPassengerFacilityTT] ([EPassengerFacilityTTId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormationTT_EReservationInfo] FOREIGN KEY ([ReservationInfo]) REFERENCES [dbo].[EReservationInfo] ([EReservationInfoId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

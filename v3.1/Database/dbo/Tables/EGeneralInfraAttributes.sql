CREATE TABLE [dbo].[EGeneralInfraAttributes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EGeneralInfraAttributesId]	BIGINT		NOT NULL,
	[GeneralInfraAttribute]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EGeneralInfraAttributesId] PRIMARY KEY CLUSTERED ([EGeneralInfraAttributesId] ASC),
	CONSTRAINT [FK_EGeneralInfraAttributes_EGeneralInfraAttribute] FOREIGN KEY ([GeneralInfraAttribute]) REFERENCES [dbo].[EGeneralInfraAttribute] ([EGeneralInfraAttributeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

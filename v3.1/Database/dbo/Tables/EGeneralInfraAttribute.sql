CREATE TABLE [dbo].[EGeneralInfraAttribute]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EGeneralInfraAttributeId]	BIGINT			NOT NULL,
	[Attributes]				BIGINT			NOT NULL,
	[Any]						VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_EGeneralInfraAttributeId] PRIMARY KEY CLUSTERED ([EGeneralInfraAttributeId] ASC),
	CONSTRAINT [FK_EGeneralInfraAttribute_EAttributes] FOREIGN KEY ([Attributes]) REFERENCES [dbo].[EAttributes] ([EAttributesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

CREATE TABLE [dbo].[EAttributes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EAttributesId]	BIGINT		NOT NULL,
	[Attribute]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EAttributesId] PRIMARY KEY CLUSTERED ([EAttributesId] ASC),
	CONSTRAINT [FK_EAttributes_TAttribute] FOREIGN KEY ([Attribute]) REFERENCES [dbo].[TAttribute] ([TAttributeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

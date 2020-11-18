CREATE TABLE [dbo].[EExternalReferenceTrainNumber]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EExternalReferenceTrainNumberId]	BIGINT			NOT NULL,
	[OrganizationalUnitBinding]	BIGINT			NOT NULL,
	[TrainNumber]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_EExternalReferenceTrainNumberId] PRIMARY KEY CLUSTERED ([EExternalReferenceTrainNumberId] ASC),
	CONSTRAINT [FK_EExternalReferenceTrainNumber_EOrganizationalUnitBinding] FOREIGN KEY ([OrganizationalUnitBinding]) REFERENCES [dbo].[EOrganizationalUnitBinding] ([EOrganizationalUnitBindingId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

CREATE TABLE [dbo].[EMileageChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EMileageChangesId]	BIGINT		NOT NULL,
	[MileageChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EMileageChangesId] PRIMARY KEY CLUSTERED ([EMileageChangesId] ASC),
	CONSTRAINT [FK_EMileageChanges_TMileageChange] FOREIGN KEY ([MileageChange]) REFERENCES [dbo].[TMileageChange] ([TMileageChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

CREATE TABLE [dbo].[TMileageChangeDescr]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMileageChangeDescrId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(11)	NOT NULL,

	CONSTRAINT [PK_TMileageChangeDescrId] PRIMARY KEY CLUSTERED ([TMileageChangeDescrId] ASC)
);

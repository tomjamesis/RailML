CREATE TABLE [dbo].[TMileageDirection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMileageDirectionId]	TINYINT		NOT NULL,
	[Value]			NVARCHAR(7)	NOT NULL,

	CONSTRAINT [PK_TMileageDirectionId] PRIMARY KEY CLUSTERED ([TMileageDirectionId] ASC)
);

CREATE TABLE [dbo].[EOperationControlPoints]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOperationControlPointsId]	BIGINT		NOT NULL,
	[Ocp]						SMALLINT		NOT NULL,

	CONSTRAINT [PK_EOperationControlPointsId] PRIMARY KEY CLUSTERED ([EOperationControlPointsId] ASC),
	CONSTRAINT [FK_EOperationControlPoints_EOcp] FOREIGN KEY ([Ocp]) REFERENCES [dbo].[EOcp] ([EOcpId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

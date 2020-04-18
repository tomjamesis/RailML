CREATE TABLE [dbo].[EControllers]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EControllersId]	BIGINT		NOT NULL,
	[Controller]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EControllersId] PRIMARY KEY CLUSTERED ([EControllersId] ASC),
	CONSTRAINT [FK_EControllers_TController] FOREIGN KEY ([Controller]) REFERENCES [dbo].[TController] ([TControllerId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

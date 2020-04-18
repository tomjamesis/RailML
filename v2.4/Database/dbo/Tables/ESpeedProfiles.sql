CREATE TABLE [dbo].[ESpeedProfiles]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ESpeedProfilesId]	BIGINT		NOT NULL,
	[SpeedProfile]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ESpeedProfilesId] PRIMARY KEY CLUSTERED ([ESpeedProfilesId] ASC),
	CONSTRAINT [FK_ESpeedProfiles_TSpeedProfile] FOREIGN KEY ([SpeedProfile]) REFERENCES [dbo].[TSpeedProfile] ([TSpeedProfileId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

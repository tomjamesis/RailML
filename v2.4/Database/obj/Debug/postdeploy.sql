--Auto generated code from XmlSchemaSQLClassGenerator on 14:20 19-Apr-2020

USE [XSDtoSQL]
GO

INSERT [dbo].[TVerbalCounter] ([TVerbalCounterId], [Value]) VALUES (1, N'Single')
GO
INSERT [dbo].[TVerbalCounter] ([TVerbalCounterId], [Value]) VALUES (2, N'Double')
GO
INSERT [dbo].[TVerbalCounter] ([TVerbalCounterId], [Value]) VALUES (3, N'Triple')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TLaxDirection] ([TLaxDirectionId], [Value]) VALUES (1, N'Up')
GO
INSERT [dbo].[TLaxDirection] ([TLaxDirectionId], [Value]) VALUES (2, N'Down')
GO
INSERT [dbo].[TLaxDirection] ([TLaxDirectionId], [Value]) VALUES (3, N'Unknown')
GO
INSERT [dbo].[TLaxDirection] ([TLaxDirectionId], [Value]) VALUES (4, N'None')
GO
INSERT [dbo].[TLaxDirection] ([TLaxDirectionId], [Value]) VALUES (5, N'Both')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TExtendedDirection] ([TExtendedDirectionId], [Value]) VALUES (1, N'Up')
GO
INSERT [dbo].[TExtendedDirection] ([TExtendedDirectionId], [Value]) VALUES (2, N'Down')
GO
INSERT [dbo].[TExtendedDirection] ([TExtendedDirectionId], [Value]) VALUES (3, N'Unknown')
GO
INSERT [dbo].[TExtendedDirection] ([TExtendedDirectionId], [Value]) VALUES (4, N'None')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TDelimitedDirection] ([TDelimitedDirectionId], [Value]) VALUES (1, N'Up')
GO
INSERT [dbo].[TDelimitedDirection] ([TDelimitedDirectionId], [Value]) VALUES (2, N'Down')
GO
INSERT [dbo].[TDelimitedDirection] ([TDelimitedDirectionId], [Value]) VALUES (3, N'Unknown')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TStrictDirection] ([TStrictDirectionId], [Value]) VALUES (1, N'Up')
GO
INSERT [dbo].[TStrictDirection] ([TStrictDirectionId], [Value]) VALUES (2, N'Down')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TMileageDirection] ([TMileageDirectionId], [Value]) VALUES (1, N'Raising')
GO
INSERT [dbo].[TMileageDirection] ([TMileageDirectionId], [Value]) VALUES (2, N'Falling')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TTrainAlignment] ([TTrainAlignmentId], [Value]) VALUES (1, N'Head')
GO
INSERT [dbo].[TTrainAlignment] ([TTrainAlignmentId], [Value]) VALUES (2, N'Center')
GO
INSERT [dbo].[TTrainAlignment] ([TTrainAlignmentId], [Value]) VALUES (3, N'Rear')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TBrakeUse] ([TBrakeUseId], [Value]) VALUES (1, N'Unknown')
GO
INSERT [dbo].[TBrakeUse] ([TBrakeUseId], [Value]) VALUES (2, N'Normal')
GO
INSERT [dbo].[TBrakeUse] ([TBrakeUseId], [Value]) VALUES (3, N'Emergency')
GO
INSERT [dbo].[TBrakeUse] ([TBrakeUseId], [Value]) VALUES (4, N'Both')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TAirBrakeApplicationPosition] ([TAirBrakeApplicationPositionId], [Value]) VALUES (1, N'NSlashA')
GO
INSERT [dbo].[TAirBrakeApplicationPosition] ([TAirBrakeApplicationPositionId], [Value]) VALUES (2, N'G')
GO
INSERT [dbo].[TAirBrakeApplicationPosition] ([TAirBrakeApplicationPositionId], [Value]) VALUES (3, N'P')
GO
INSERT [dbo].[TAirBrakeApplicationPosition] ([TAirBrakeApplicationPositionId], [Value]) VALUES (4, N'R')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (1, N'None')
GO
INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (2, N'Mechanical')
GO
INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (3, N'Electric')
GO
INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (4, N'Inductive')
GO
INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (5, N'Magnetic')
GO
INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (6, N'Optical')
GO
INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (7, N'Radio')
GO
INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (8, N'Rail')
GO
INSERT [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId], [Value]) VALUES (9, N'Cable')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TTrainProtectionMonitoring] ([TTrainProtectionMonitoringId], [Value]) VALUES (1, N'None')
GO
INSERT [dbo].[TTrainProtectionMonitoring] ([TTrainProtectionMonitoringId], [Value]) VALUES (2, N'Intermittent')
GO
INSERT [dbo].[TTrainProtectionMonitoring] ([TTrainProtectionMonitoringId], [Value]) VALUES (3, N'Continuous')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TInterlockingTypes] ([TInterlockingTypesId], [Value]) VALUES (1, N'None')
GO
INSERT [dbo].[TInterlockingTypes] ([TInterlockingTypesId], [Value]) VALUES (2, N'Mechanical')
GO
INSERT [dbo].[TInterlockingTypes] ([TInterlockingTypesId], [Value]) VALUES (3, N'Electro_Mechanical')
GO
INSERT [dbo].[TInterlockingTypes] ([TInterlockingTypesId], [Value]) VALUES (4, N'Electrical')
GO
INSERT [dbo].[TInterlockingTypes] ([TInterlockingTypesId], [Value]) VALUES (5, N'Electronical')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TTiltingActuationType] ([TTiltingActuationTypeId], [Value]) VALUES (1, N'None')
GO
INSERT [dbo].[TTiltingActuationType] ([TTiltingActuationTypeId], [Value]) VALUES (2, N'Active')
GO
INSERT [dbo].[TTiltingActuationType] ([TTiltingActuationTypeId], [Value]) VALUES (3, N'Passive')
GO
INSERT [dbo].[TTiltingActuationType] ([TTiltingActuationTypeId], [Value]) VALUES (4, N'RollCompensation')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TUsageType] ([TUsageTypeId], [Value]) VALUES (1, N'Passenger')
GO
INSERT [dbo].[TUsageType] ([TUsageTypeId], [Value]) VALUES (2, N'Goods')
GO
INSERT [dbo].[TUsageType] ([TUsageTypeId], [Value]) VALUES (3, N'Mixed')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TControllerTechnologyType] ([TControllerTechnologyTypeId], [Value]) VALUES (1, N'Manual')
GO
INSERT [dbo].[TControllerTechnologyType] ([TControllerTechnologyTypeId], [Value]) VALUES (2, N'Mechanical')
GO
INSERT [dbo].[TControllerTechnologyType] ([TControllerTechnologyTypeId], [Value]) VALUES (3, N'Electro_Mechanical')
GO
INSERT [dbo].[TControllerTechnologyType] ([TControllerTechnologyTypeId], [Value]) VALUES (4, N'Electrical')
GO
INSERT [dbo].[TControllerTechnologyType] ([TControllerTechnologyTypeId], [Value]) VALUES (5, N'Electronic')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TMaxTrainCurrentType] ([TMaxTrainCurrentTypeId], [Value]) VALUES (1, N'Driving')
GO
INSERT [dbo].[TMaxTrainCurrentType] ([TMaxTrainCurrentTypeId], [Value]) VALUES (2, N'Standstill')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TMaxTrainCurrentValidFor] ([TMaxTrainCurrentValidForId], [Value]) VALUES (1, N'Train')
GO
INSERT [dbo].[TMaxTrainCurrentValidFor] ([TMaxTrainCurrentValidForId], [Value]) VALUES (2, N'Pantograph')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TMileageChangeDescr] ([TMileageChangeDescrId], [Value]) VALUES (1, N'Overlapping')
GO
INSERT [dbo].[TMileageChangeDescr] ([TMileageChangeDescrId], [Value]) VALUES (2, N'Missing')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TOcpCenterSide] ([TOcpCenterSideId], [Value]) VALUES (1, N'Left')
GO
INSERT [dbo].[TOcpCenterSide] ([TOcpCenterSideId], [Value]) VALUES (2, N'Right')
GO
INSERT [dbo].[TOcpCenterSide] ([TOcpCenterSideId], [Value]) VALUES (3, N'Above')
GO
INSERT [dbo].[TOcpCenterSide] ([TOcpCenterSideId], [Value]) VALUES (4, N'Below')
GO
INSERT [dbo].[TOcpCenterSide] ([TOcpCenterSideId], [Value]) VALUES (5, N'Ahead')
GO
INSERT [dbo].[TOcpCenterSide] ([TOcpCenterSideId], [Value]) VALUES (6, N'Behind')
GO
INSERT [dbo].[TOcpCenterSide] ([TOcpCenterSideId], [Value]) VALUES (7, N'None')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TSide] ([TSideId], [Value]) VALUES (1, N'Left')
GO
INSERT [dbo].[TSide] ([TSideId], [Value]) VALUES (2, N'Right')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TBaliseLinkReaction] ([TBaliseLinkReactionId], [Value]) VALUES (1, N'TrainTrip')
GO
INSERT [dbo].[TBaliseLinkReaction] ([TBaliseLinkReactionId], [Value]) VALUES (2, N'ApplyServiceBrake')
GO
INSERT [dbo].[TBaliseLinkReaction] ([TBaliseLinkReactionId], [Value]) VALUES (3, N'NoReaction')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (1, N'Center')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (2, N'LeftRail')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (3, N'LeftRailInside')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (4, N'LeftRailOutside')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (5, N'RightRail')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (6, N'RightRailInside')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (7, N'RightRailOutside')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (8, N'Outside')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (9, N'OutsideLeft')
GO
INSERT [dbo].[TPosInTrack] ([TPosInTrackId], [Value]) VALUES (10, N'OutsideRight')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TInsulatedRailSide] ([TInsulatedRailSideId], [Value]) VALUES (1, N'None')
GO
INSERT [dbo].[TInsulatedRailSide] ([TInsulatedRailSideId], [Value]) VALUES (2, N'Left')
GO
INSERT [dbo].[TInsulatedRailSide] ([TInsulatedRailSideId], [Value]) VALUES (3, N'Right')
GO
INSERT [dbo].[TInsulatedRailSide] ([TInsulatedRailSideId], [Value]) VALUES (4, N'Both')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TDerailKind] ([TDerailKindId], [Value]) VALUES (1, N'BlockDerail')
GO
INSERT [dbo].[TDerailKind] ([TDerailKindId], [Value]) VALUES (2, N'SingleCatchPoints')
GO
INSERT [dbo].[TDerailKind] ([TDerailKindId], [Value]) VALUES (3, N'DoubleCatchPoints')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TSpeedRangeType] ([TSpeedRangeTypeId], [Value]) VALUES (1, N'Dontcare')
GO
INSERT [dbo].[TSpeedRangeType] ([TSpeedRangeTypeId], [Value]) VALUES (2, N'Slow')
GO
INSERT [dbo].[TSpeedRangeType] ([TSpeedRangeTypeId], [Value]) VALUES (3, N'Fast')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TLoadSwitch] ([TLoadSwitchId], [Value]) VALUES (1, N'Empty')
GO
INSERT [dbo].[TLoadSwitch] ([TLoadSwitchId], [Value]) VALUES (2, N'Full')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TCabPositionType] ([TCabPositionTypeId], [Value]) VALUES (1, N'None')
GO
INSERT [dbo].[TCabPositionType] ([TCabPositionTypeId], [Value]) VALUES (2, N'Front')
GO
INSERT [dbo].[TCabPositionType] ([TCabPositionTypeId], [Value]) VALUES (3, N'Middle')
GO
INSERT [dbo].[TCabPositionType] ([TCabPositionTypeId], [Value]) VALUES (4, N'Rear')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TEndPositionType] ([TEndPositionTypeId], [Value]) VALUES (1, N'Both')
GO
INSERT [dbo].[TEndPositionType] ([TEndPositionTypeId], [Value]) VALUES (2, N'Front')
GO
INSERT [dbo].[TEndPositionType] ([TEndPositionTypeId], [Value]) VALUES (3, N'Rear')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TRelatedPositionType] ([TRelatedPositionTypeId], [Value]) VALUES (1, N'None')
GO
INSERT [dbo].[TRelatedPositionType] ([TRelatedPositionTypeId], [Value]) VALUES (2, N'Aside')
GO
INSERT [dbo].[TRelatedPositionType] ([TRelatedPositionTypeId], [Value]) VALUES (3, N'Ontop')
GO
INSERT [dbo].[TRelatedPositionType] ([TRelatedPositionTypeId], [Value]) VALUES (4, N'Below')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TSpecialServiceType] ([TSpecialServiceTypeId], [Value]) VALUES (1, N'Include')
GO
INSERT [dbo].[TSpecialServiceType] ([TSpecialServiceTypeId], [Value]) VALUES (2, N'Exclude')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TTrainType] ([TTrainTypeId], [Value]) VALUES (1, N'Operational')
GO
INSERT [dbo].[TTrainType] ([TTrainTypeId], [Value]) VALUES (2, N'Commercial')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TTrainScope] ([TTrainScopeId], [Value]) VALUES (1, N'Primary')
GO
INSERT [dbo].[TTrainScope] ([TTrainScopeId], [Value]) VALUES (2, N'Secondary')
GO
INSERT [dbo].[TTrainScope] ([TTrainScopeId], [Value]) VALUES (3, N'SecondaryStart')
GO
INSERT [dbo].[TTrainScope] ([TTrainScopeId], [Value]) VALUES (4, N'SecondaryEnd')
GO
INSERT [dbo].[TTrainScope] ([TTrainScopeId], [Value]) VALUES (5, N'SecondaryInner')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TOcpTTType] ([TOcpTTTypeId], [Value]) VALUES (1, N'Stop')
GO
INSERT [dbo].[TOcpTTType] ([TOcpTTTypeId], [Value]) VALUES (2, N'Pass')
GO
INSERT [dbo].[TOcpTTType] ([TOcpTTTypeId], [Value]) VALUES (3, N'Begin')
GO
INSERT [dbo].[TOcpTTType] ([TOcpTTTypeId], [Value]) VALUES (4, N'End')
GO

USE [XSDtoSQL]
GO

INSERT [dbo].[TOnOff] ([TOnOffId], [Value]) VALUES (1, N'Both')
GO
INSERT [dbo].[TOnOff] ([TOnOffId], [Value]) VALUES (2, N'On')
GO
INSERT [dbo].[TOnOff] ([TOnOffId], [Value]) VALUES (3, N'Off')
GO

GO

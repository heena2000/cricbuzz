SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (1, N'India')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (2, N'England')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (3, N'Pakistan')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (4, N'Australia')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (5, N'England')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (6, N'South Africa')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (7, N'Sri Lanka')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (8, N'Ireland')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (9, N'West Indies')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (10, N'Zimbabwe')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (11, N'Afghanistan')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (12, N'New Zealand')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[OdiRankings] ON 
GO
INSERT [dbo].[OdiRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (1, N'Kane Williamson', 919, 12)
GO
INSERT [dbo].[OdiRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (2, N'Steve Smith', 891, 4)
GO
INSERT [dbo].[OdiRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (3, N'Marnus Labuschagne', 878, 4)
GO
INSERT [dbo].[OdiRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (4, N'Joe Root', 853, 2)
GO
INSERT [dbo].[OdiRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (5, N'Virat Kohli', 836, 1)
GO
INSERT [dbo].[OdiRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (6, N'Babar Azam', 760, 3)
GO
INSERT [dbo].[OdiRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (7, N'Henry Nicholls', 747, 12)
GO
INSERT [dbo].[OdiRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (8, N'Rohit Sharma', 742, 1)
GO
SET IDENTITY_INSERT [dbo].[OdiRankings] OFF
GO
SET IDENTITY_INSERT [dbo].[TestRankings] ON 
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (1, N'Virat Kohli', 870, 1)
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (2, N'Rohit Sharma', 842, 1)
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (3, N'Baba Azam', 837, 3)
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (4, N'Ross Taylor', 818, 12)
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (5, N'Aaron Finch', 791, 4)
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (6, N'Faf Du Plessis', 790, 6)
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (7, N'David Warner', 773, 4)
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (8, N'Kane Williamson', 765, 12)
GO
INSERT [dbo].[TestRankings] ([Id], [PlayerName], [Rating], [CountryId]) VALUES (9, N'Quinton de Kock', 755, 6)
GO
SET IDENTITY_INSERT [dbo].[TestRankings] OFF
GO
SET IDENTITY_INSERT [dbo].[Tours] ON 
GO
INSERT [dbo].[Tours] ([Id], [TourName], [Description], [Period], [CountryId]) VALUES (1, N'England tour of India, 2021', N'Test 4, ODI 3, T20 5', N'Feb 05 - Mar 28', 1)
GO
INSERT [dbo].[Tours] ([Id], [TourName], [Description], [Period], [CountryId]) VALUES (2, N'Australia tour of New Zealand, 2021', N'T20 5', N'Feb 22 - Mar 07', 12)
GO
INSERT [dbo].[Tours] ([Id], [TourName], [Description], [Period], [CountryId]) VALUES (3, N'Sri Lanka tour of West Indies, 2021', N'3 T20 , 3 ODI, 2 Test', N'Mar 03 - Apr 02', 9)
GO
INSERT [dbo].[Tours] ([Id], [TourName], [Description], [Period], [CountryId]) VALUES (4, N'Bangladesh tour of New Zealand, 2021', N'3 ODI, 3 T20', N'Mar 20 - Apr 01', 12)
GO
INSERT [dbo].[Tours] ([Id], [TourName], [Description], [Period], [CountryId]) VALUES (5, N'Pakistan tour of South Africa, 2021', N'3 ODI, 4 T20', N'Apr 02 - Apr 16', 6)
GO
INSERT [dbo].[Tours] ([Id], [TourName], [Description], [Period], [CountryId]) VALUES (6, N'New Zealand tour of England, 2021', N'2 Test', N'Jun 02 - Jun 14', 1)
GO
SET IDENTITY_INSERT [dbo].[Tours] OFF
GO
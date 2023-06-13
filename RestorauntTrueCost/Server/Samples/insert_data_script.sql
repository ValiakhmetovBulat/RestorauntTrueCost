--
-- PostgreSQL database dump
--

-- Dumped from database version 15.2
-- Dumped by pg_dump version 15.2

-- Started on 2023-06-02 08:25:47

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'WIN1251';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 3435 (class 0 OID 16486)
-- Dependencies: 215
-- Data for Name: Sections; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Sections" ("Id", "Name", "NameRU") VALUES (1, 'bar', '���');
INSERT INTO public."Sections" ("Id", "Name", "NameRU") VALUES (2, 'main', '��������');
INSERT INTO public."Sections" ("Id", "Name", "NameRU") VALUES (3, 'company', '��� ��������');
INSERT INTO public."Sections" ("Id", "Name", "NameRU") VALUES (4, 'buisness', '������-�����');


--
-- TOC entry 3436 (class 0 OID 16495)
-- Dependencies: 216
-- Data for Name: PositionTypes; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (1, 'coctails', '��������', 1);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (2, 'aperetifs', '���������, ������', 1);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (3, 'congac', '������, ������, �����', 1);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (4, 'wines', '����, ����������', 1);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (5, 'whiskey', '�����, ������, ���', 1);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (6, 'vodka', '�����, ����, ������', 1);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (7, 'beer', '����', 1);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (8, 'coffee-tea', '���, ����, ����', 1);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (9, 'cold-starters', '�������� �������', 2);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (10, 'paste', '�����', 2);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (11, 'salads', '������', 2);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (12, 'kebabs', '��������', 2);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (13, 'main-course', '������� �����', 2);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (14, 'soup', '����', 2);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (15, 'deserts', '�������', 2);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (16, 'asd', 'asd', NULL);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (17, 'summerMenu', '������ ����', NULL);
INSERT INTO public."PositionTypes" ("Id", "Name", "NameRu", "SectionId") VALUES (18, 'New', '�����', 1);


--
-- TOC entry 3437 (class 0 OID 16525)
-- Dependencies: 217
-- Data for Name: MenuPositions; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (1, '������� �� ������� ����', 200, 1, '�����, ��� �����, ������� ����, ������� �������, �������, ��������, ����, ����', 'sangria-red-wine.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (2, '������ �����', 100, 1, '������ ������, �������� �����, ��� �����, ������ �����, �����, ����� �����������, ���', 'brendi-sauer.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (3, '�����������', 550, 1, '����, ������ ������, ����� ������, ��� �����, �������� �����, ������ �����, �������� ����, ������', 'frantsuzhenka.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (4, '������������ �����', 450, 1, '����� �����, ����� ����� ���, ��� �����, ������� �������, ������� ������, ������������ �����', 'kosmopolitan.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (5, '������� �� ����� ����', 350, 1, '�����, ��� �����, ����� ����, �������� ���, �������, ��������, �����, ���� ����, ����', 'sangriya-white-wine.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (6, '������� ��������������', 250, 1, '�����, ��� �����, �������� ���, �������� ���, ���. ����, ���������, ��������, �����, ����', 'sangriya-bezalkogolnaya.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (7, '������� ��� �������', 1150, 9, '��������� � �������, �������� ������� ������, ������������ ����������, �������� ��������, ��������, ������������ ��������, ���� ��������, ����� � �����, ������ �� ��������, ����� �� �������������� �������', 'assorti-pod-vodochku.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (8, '������� �� �����', 940, 9, '���������� ���, �����, ��������, �������� ���, ��� ���, ����, ������ � ��������� ����� � �������, ���, ��������, �����', 'syrnoe-assorti.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (9, '���� �������� ������� ������', 480, 9, 'C �������� ����������, ������������ �����, ������������ �������, �����, ��������� ������ � �������', 'skumbrii-pryanogo-posola.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (10, '������ �������', 480, 9, 'C �������� ����������, ������������ �����, �������, �������� �����, �������� � �������', 'seld-solenaya.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (11, '������ �������', 1100, 9, '������, ��������, ������ ������� ������ � �������� � ������� �����, ����� � ������', 'rybnoe-assorti.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (12, '����� �� ����� � ������', 990, 9, '��� ��������� ���������� � ���������� ���������, ������� � ����������', 'krudo-iz-tuntsa-i-lososya.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (13, '���������� ����', 330, 15, '� ������ ������ �� ����', 'brusn-tort.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (14, '���������� ������', 350, 15, '� ���������, ���������, �������� � �����', 'choko-fondan.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (15, '�������', 370, 15, '������ ��������� ������ �� ������ ���� �����������', 'cheese-cake.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (16, '������� � ���������� �� ��������-����������� ������', 260, 15, '', 'merengi-i-profitroli.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (17, '��������', 270, 15, '� ���������� ������', 'napoleon.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (18, '�������� ��������', 370, 15, '� ������, �������, ������� � ���������', 'shtrudel.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (19, '��������, ������� � �������� �����', 690, 13, 'C ������� ����� � �������� � ������������ ���� � �������', 'telyatina-min.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (20, '����� �� ��������', 780, 13, '�� ��������� � ������ �� ����������', 'stejk-iz-govyadiny.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (21, '��������� �����', 850, 13, '�� �������� � ������� ��������', 'medalony-gril.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (22, '������� �������', 590, 13, '�� ������� �� ����� � ���������� ���', 'venskij-shnitsel.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (23, '���������� ������ �������� �������', 790, 13, '� ������������� ��������', 'rebryshki.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (24, '�������� ��������', 650, 13, '� �����, ����� �����, ������������ ���������� � ���������� � ���������', 'rublenyj-bifshteks.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (25, '������ � ��������� � �������', 550, 10, '� �����-������� �����', 'shretsle-s-govyadinoj.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (26, '������ ���������', 550, 10, '� ������� � ����� ��������', 'shpetsle-karbonara.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (27, '����� � ���� �� �������� ��������', 550, 10, '� ������� � ��������-������ ������', 'penne.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (28, '������ � ������� ����', 580, 11, '� �������� ������ ������ � �������, ������ ������, ����� ��������, ���������� ����������, �������� ����� � �������', 'tsezar.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (29, '��������� �����', 550, 11, '������ ������, ������ �����, ���������� �����, ������ �������, ������, ��� ����, �������� ����, ������, ��������� �����', 'grecheskij.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (30, '����� � ���������� �����������', 480, 11, '��������, ������� ���������, �������� ����, ������, �����, ��������� ����', 'baklazhan.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (31, '����� � ���������', 590, 11, '� ������� �������, ������� �������, ������������ ���������� ������, �����, ���������� ��� ������ ���������� ����', 's-buzheninoj.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (32, '����� � ���������� ���������', 570, 11, '� ���������� ������, ������������ ���������� ��� ��������� ��������� � �������� ��������', 's-obzharennoj-govyadinoj.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (33, '�����-���� � ������� ������� ������', 590, 11, '� ��������� �������� � �������, ��������� ������� ��� ������ �� ��������� �������', 's-lososem.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (34, '�� ��', 450, 14, '����������� ��� �� �������� � ������� ������, �������� ���, ������� � ������������� ��������', 'fo-bo.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (35, '��� ��', 630, 14, '� �������������� � �����', 'tom-yAm.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (36, '������� ������ � ����� � ���� �����', 250, 14, '', 'kurinyj-bulon.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (37, '���� � ���������', 340, 14, '� �������� ���� �� ������� ����� � ��������', 'borshh.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (38, '���-���� �������', 340, 14, '�� ����������� � ��������� � ���������� � �������', 'pyure-gribnoj.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (39, '���������� ���-�����', 370, 14, '������ ��� � ��������� �������� � ���������� ������, ����������, ���������, �����, �������� � ���������', 'sup-gulyash.jpg');



--
-- TOC entry 3460 (class 0 OID 82924)
-- Dependencies: 240
-- Data for Name: Roles; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Roles" ("Id", "Name", "Description") VALUES (1, 'Admin', '');
INSERT INTO public."Roles" ("Id", "Name", "Description") VALUES (2, 'Manager', '');
INSERT INTO public."Roles" ("Id", "Name", "Description") VALUES (3, 'User', '');


--
-- TOC entry 3444 (class 0 OID 49306)
-- Dependencies: 224
-- Data for Name: Users; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Users" VALUES (47, '2023-05-23 16:00:58.241401+03', 'admin@example.com', '4c4fe172581eb4ca44603399f18a060a', '�����', '89874166850', '�����������', 1);
INSERT INTO public."Users" VALUES (68, '2023-06-13 21:22:02.081+03', 'user@example.com', '34b9e6bee0b8d41f357369065b20d5f4', '�����', '89999999999', '�����������', 3);
INSERT INTO public."Users" VALUES (69, '2023-06-13 21:22:26.808+03', 'manager@example.com', 'f4109c28c3a12c62959cfa16e61be870', '�����', '89999999999', '�����������', 2);

--
-- TOC entry 3452 (class 0 OID 66127)
-- Dependencies: 232
-- Data for Name: OrderPeriods; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."OrderPeriods" ("Id", "FromTo") VALUES (1, '00-02');
INSERT INTO public."OrderPeriods" ("Id", "FromTo") VALUES (2, '10-12');
INSERT INTO public."OrderPeriods" ("Id", "FromTo") VALUES (3, '12-14');
INSERT INTO public."OrderPeriods" ("Id", "FromTo") VALUES (4, '14-16');
INSERT INTO public."OrderPeriods" ("Id", "FromTo") VALUES (5, '16-18');
INSERT INTO public."OrderPeriods" ("Id", "FromTo") VALUES (6, '18-20');
INSERT INTO public."OrderPeriods" ("Id", "FromTo") VALUES (7, '20-22');
INSERT INTO public."OrderPeriods" ("Id", "FromTo") VALUES (8, '22-00');

--
-- TOC entry 3457 (class 0 OID 82541)
-- Dependencies: 237
-- Data for Name: OrderStatus; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."OrderStatus" ("Id", "Name", "HashColor") VALUES (2, '������ ����������', '#ffa763');
INSERT INTO public."OrderStatus" ("Id", "Name", "HashColor") VALUES (3, '�������� ������', '#4ABBA4');
INSERT INTO public."OrderStatus" ("Id", "Name", "HashColor") VALUES (4, '�������', '#ed8e82');
INSERT INTO public."OrderStatus" ("Id", "Name", "HashColor") VALUES (1, '�����', '#fde6ff');

--
-- TOC entry 3442 (class 0 OID 16595)
-- Dependencies: 222
-- Data for Name: Reviews; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Reviews" ("Id", "DateOfVisit", "NumberOfGuests", "TableNumber", "Message", "IsAccepted", "UserId", "DatePosted") VALUES (7, '2023-05-25 00:00:00+03', NULL, NULL, '6954ghg', false, 47, '2023-05-28 18:12:37.631');


--
-- TOC entry 3448 (class 0 OID 66027)
-- Dependencies: 228
-- Data for Name: Tables; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (1, 100, 4, 800);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (2, 101, 4, 800);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (3, 102, 4, 800);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (4, 103, 2, 400);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (5, 104, 2, 500);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (6, 105, 6, 1200);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (7, 106, 2, 400);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (8, 107, 4, 800);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (9, 108, 4, 800);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (10, 109, 6, 1200);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (11, 110, 2, 500);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (12, 111, 2, 400);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (13, 112, 6, 1200);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (14, 113, 2, 400);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (15, 114, 4, 900);
INSERT INTO public."Tables" ("Id", "TableNum", "GuestNum", "ReserveCost") VALUES (16, 115, 6, 1200);


--
-- TOC entry 3434 (class 0 OID 16480)
-- Dependencies: 214
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123133511_InitialDatabase', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123134048_FixedPositionTableName', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123140024_AddedPKeys', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123140157_AddedIdentity', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123140659_DeletedAutoGen', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123140905_xd', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123171730_FixedReferences', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123172600_TotallyFixedReferences', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230123174952_AddedDescriptionOfPositionsColumn', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230125174543_AddedNavigationProps', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230125175420_idkwhat', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230125175624_idk', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230125180422_asdasd', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230125181107_wtf', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230125183524_sadasdsad', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230125220300_AddedIdentityIdColumns', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230126141234_AddedAdminAndReviewEntities', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230129200753_SetIdentity', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230201142233_AddedVirtualToFK', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230202144624_SettedReviewsTableAdminAllowsNull', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230202145034_SettedReviewAdminNull', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230203122419_Changed Date Of Visit (Review Table) data type from DateOnly to DateTime', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230203123341_SwitchedToDateOnlyAgain', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230204182333_PhotoToStringAddedNameRuFieldToTypes', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230310135554_Added User Entity', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230310142353_Changed Password Policy', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230314144351_Removed username field from User entity', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230315093555_Added FK User to Reviews', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230315154458_added roles to users', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230317193132_added nameRU to section table', '7.0.3');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230324080604_asd', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230324083158_Fixed', '7.0.2');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230406123804_review_to_users', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230406142233_User_Phone_Can_be_NULL', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230406144338_set_null_to_user_in_review_table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230417105329_added datePostedToReview', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230424163824_added profile table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230424173325_removed profile table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230501085723_added orders and tables table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230504162508_added TableOrder table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230505102554_added order logic', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230508142405_unique table number', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230508161616_order periods', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230510085421_changed order period logic', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230510115528_orders to tables', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230510133756_removed orders to tables Table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230510140929_added foreign keys to table order', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230517173821_added cart table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230517175724_added orders to positions table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230518135619_added carts', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230518142357_changed cart logic', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230518151306_fixed cart table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230519184507_fixed order to position', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230522150559_added order-status table', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230522151157_added orderstatusId required', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230522151907_added order status hash color', '7.0.4');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230523105242_Roles Table', '7.0.5');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230523105541_Set User RoleId NOT NULL', '7.0.5');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230523135051_added identity', '7.0.5');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230523135543_removed admins table', '7.0.5');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20230523155331_otkat', '7.0.5');


--
-- TOC entry 3466 (class 0 OID 0)
-- Dependencies: 235
-- Name: CartToPositions_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."CartToPositions_Id_seq"', 163, true);


--
-- TOC entry 3467 (class 0 OID 0)
-- Dependencies: 220
-- Name: MenuPositions_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."MenuPositions_Id_seq"', 3, true);


--
-- TOC entry 3468 (class 0 OID 0)
-- Dependencies: 231
-- Name: OrderPeriods_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."OrderPeriods_Id_seq"', 1, false);


--
-- TOC entry 3469 (class 0 OID 0)
-- Dependencies: 238
-- Name: OrderStatus_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."OrderStatus_Id_seq"', 1, false);


--
-- TOC entry 3470 (class 0 OID 0)
-- Dependencies: 233
-- Name: OrderToPositions_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."OrderToPositions_Id_seq"', 62, true);


--
-- TOC entry 3471 (class 0 OID 0)
-- Dependencies: 225
-- Name: Orders_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Orders_Id_seq"', 58, true);


--
-- TOC entry 3472 (class 0 OID 0)
-- Dependencies: 219
-- Name: PositionTypes_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."PositionTypes_Id_seq"', 1, false);


--
-- TOC entry 3473 (class 0 OID 0)
-- Dependencies: 221
-- Name: Reviews_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Reviews_Id_seq"', 7, true);


--
-- TOC entry 3474 (class 0 OID 0)
-- Dependencies: 239
-- Name: Roles_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Roles_Id_seq"', 1, false);


--
-- TOC entry 3475 (class 0 OID 0)
-- Dependencies: 218
-- Name: Sections_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Sections_Id_seq"', 4, true);


--
-- TOC entry 3476 (class 0 OID 0)
-- Dependencies: 229
-- Name: TableOrders_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."TableOrders_Id_seq"', 62, true);


--
-- TOC entry 3477 (class 0 OID 0)
-- Dependencies: 227
-- Name: Tables_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Tables_Id_seq"', 1, false);


--
-- TOC entry 3478 (class 0 OID 0)
-- Dependencies: 223
-- Name: Users_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Users_Id_seq"', 66, true);


-- Completed on 2023-06-02 08:25:47

--
-- PostgreSQL database dump complete
--


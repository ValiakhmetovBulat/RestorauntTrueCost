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


--
-- TOC entry 3437 (class 0 OID 16525)
-- Dependencies: 217
-- Data for Name: MenuPositions; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (1, '������� �� ������� ����', 200, 1, '�����, ��� �����, ������� ����, ������� �������, �������, ��������, ����, ����', 'sangria-red-wine.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (2, '������ �����', 160, 1, '������ ������, �������� �����, ��� �����, ������ �����, �����, ����� �����������, ���', 'brendi-sauer.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (3, '�����������', 300, 1, '����, ������ ������, ����� ������, ��� �����, �������� �����, ������ �����, �������� ����, ������', 'frantsuzhenka.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (4, '������������ �����', 250, 1, '����� �����, ����� ����� ���, ��� �����, ������� �������, ������� ������, ������������ �����', 'kosmopolitan.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (5, '������� �� ����� ����', 180, 1, '�����, ��� �����, ����� ����, �������� ���, �������, ��������, �����, ���� ����, ����', 'sangriya-white-wine.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (6, '������� ��������������', 150, 1, '�����, ��� �����, �������� ���, �������� ���, ���. ����, ���������, ��������, �����, ����', 'sangriya-bezalkogolnaya.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (7, '������� ��� �������', 790, 9, '��������� � �������, �������� ������� ������, ������������ ����������, �������� ��������, ��������, ������������ ��������, ���� ��������, ����� � �����, ������ �� ��������, ����� �� �������������� �������', 'assorti-pod-vodochku.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (8, '������� �� �����', 750, 9, '���������� ���, �����, ��������, �������� ���, ��� ���, ����, ������ � ��������� ����� � �������, ���, ��������, �����', 'syrnoe-assorti.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (9, '���� �������� ������� ������', 320, 9, 'C �������� ����������, ������������ �����, ������������ �������, �����, ��������� ������ � �������', 'skumbrii-pryanogo-posola.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (10, '������ �������', 320, 9, 'C �������� ����������, ������������ �����, �������, �������� �����, �������� � �������', 'seld-solenaya.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (11, '������ �������', 690, 9, '������, ��������, ������ ������� ������ � �������� � ������� �����, ����� � ������', 'rybnoe-assorti.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (12, '����� �� ����� � ������', 400, 9, '��� ��������� ���������� � ���������� ���������, ������� � ����������', 'krudo-iz-tuntsa-i-lososya.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (13, '���������� ����', 200, 15, '� ������ ������ �� ����', 'brusn-tort.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (14, '���������� ������', 220, 15, '� ���������, ���������, �������� � �����', 'choko-fondan.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (15, '�������', 270, 15, '������ ��������� ������ �� ������ ���� �����������', 'cheese-cake.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (16, '������� � ���������� �� ��������-����������� ������', 260, 15, '', 'merengi-i-profitroli.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (17, '��������', 170, 15, '� ���������� ������', 'napoleon.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (18, '�������� ��������', 270, 15, '� ������, �������, ������� � ���������', 'shtrudel.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (19, '��������, ������� � �������� �����', 690, 13, 'C ������� ����� � �������� � ������������ ���� � �������', 'telyatina-min.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (20, '����� �� ��������', 480, 13, '�� ��������� � ������ �� ����������', 'stejk-iz-govyadiny.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (21, '��������� �����', 550, 13, '�� �������� � ������� ��������', 'medalony-gril.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (22, '������� �������', 390, 13, '�� ������� �� ����� � ���������� ���', 'venskij-shnitsel.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (23, '���������� ������ �������� �������', 490, 13, '� ������������� ��������', 'rebryshki.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (24, '�������� ��������', 450, 13, '� �����, ����� �����, ������������ ���������� � ���������� � ���������', 'rublenyj-bifshteks.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (25, '������ � ��������� � �������', 250, 10, '� �����-������� �����', 'shretsle-s-govyadinoj.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (26, '������ ���������', 250, 10, '� ������� � ����� ��������', 'shpetsle-karbonara.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (27, '����� � ���� �� �������� ��������', 250, 10, '� ������� � ��������-������ ������', 'penne.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (28, '������ � ������� ����', 180, 11, '� �������� ������ ������ � �������, ������ ������, ����� ��������, ���������� ����������, �������� ����� � �������', 'tsezar.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (29, '��������� �����', 180, 11, '������ ������, ������ �����, ���������� �����, ������ �������, ������, ��� ����, �������� ����, ������, ��������� �����', 'grecheskij.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (30, '����� � ���������� �����������', 200, 11, '��������, ������� ���������, �������� ����, ������, �����, ��������� ����', 'baklazhan.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (31, '����� � ���������', 180, 11, '� ������� �������, ������� �������, ������������ ���������� ������, �����, ���������� ��� ������ ���������� ����', 's-buzheninoj.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (32, '����� � ���������� ���������', 180, 11, '� ���������� ������, ������������ ���������� ��� ��������� ��������� � �������� ��������', 's-obzharennoj-govyadinoj.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (33, '�����-���� � ������� ������� ������', 220, 11, '� ��������� �������� � �������, ��������� ������� ��� ������ �� ��������� �������', 's-lososem.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (34, '�� ��', 260, 14, '����������� ��� �� �������� � ������� ������, �������� ���, ������� � ������������� ��������', 'fo-bo.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (35, '��� ��', 280, 14, '� �������������� � �����', 'tom-yAm.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (36, '������� ������ � ����� � ���� �����', 180, 14, '', 'kurinyj-bulon.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (37, '���� � ���������', 200, 14, '� �������� ���� �� ������� ����� � ��������', 'borshh.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (38, '���-���� �������', 190, 14, '�� ����������� � ��������� � ���������� � �������', 'pyure-gribnoj.jpg');
INSERT INTO public."MenuPositions" ("Id", "Name", "Price", "PositionTypeId", "Decription", "Photo") VALUES (39, '���������� ���-�����', 210, 14, '������ ��� � ��������� �������� � ���������� ������, ����������, ���������, �����, �������� � ���������', 'sup-gulyash.jpg');



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


PGDMP                         z           TestDb    14.4    14.4                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    24578    TestDb    DATABASE     e   CREATE DATABASE "TestDb" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "TestDb";
                postgres    false            ?            1259    24591    Acounts    TABLE     e   CREATE TABLE public."Acounts" (
    "accountName" text NOT NULL,
    "Contactemail" text NOT NULL
);
    DROP TABLE public."Acounts";
       public         heap    postgres    false            ?            1259    24584    Contact    TABLE     ?   CREATE TABLE public."Contact" (
    email text NOT NULL,
    contact_firstname text NOT NULL,
    contact_lastname text NOT NULL
);
    DROP TABLE public."Contact";
       public         heap    postgres    false            ?            1259    24603    Incident    TABLE     ?   CREATE TABLE public."Incident" (
    incident_name text NOT NULL,
    incident_description text NOT NULL,
    "AcountaccountName" text
);
    DROP TABLE public."Incident";
       public         heap    postgres    false            ?            1259    24579    __EFMigrationsHistory    TABLE     ?   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false                       0    24591    Acounts 
   TABLE DATA           B   COPY public."Acounts" ("accountName", "Contactemail") FROM stdin;
    public          postgres    false    211   l       ?          0    24584    Contact 
   TABLE DATA           O   COPY public."Contact" (email, contact_firstname, contact_lastname) FROM stdin;
    public          postgres    false    210   ?                 0    24603    Incident 
   TABLE DATA           ^   COPY public."Incident" (incident_name, incident_description, "AcountaccountName") FROM stdin;
    public          postgres    false    212   ?       ?          0    24579    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    209   ?       m           2606    24597    Acounts PK_Acounts 
   CONSTRAINT     _   ALTER TABLE ONLY public."Acounts"
    ADD CONSTRAINT "PK_Acounts" PRIMARY KEY ("accountName");
 @   ALTER TABLE ONLY public."Acounts" DROP CONSTRAINT "PK_Acounts";
       public            postgres    false    211            j           2606    24590    Contact PK_Contact 
   CONSTRAINT     W   ALTER TABLE ONLY public."Contact"
    ADD CONSTRAINT "PK_Contact" PRIMARY KEY (email);
 @   ALTER TABLE ONLY public."Contact" DROP CONSTRAINT "PK_Contact";
       public            postgres    false    210            p           2606    24609    Incident PK_Incident 
   CONSTRAINT     a   ALTER TABLE ONLY public."Incident"
    ADD CONSTRAINT "PK_Incident" PRIMARY KEY (incident_name);
 B   ALTER TABLE ONLY public."Incident" DROP CONSTRAINT "PK_Incident";
       public            postgres    false    212            h           2606    24583 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    209            k           1259    24615    IX_Acounts_Contactemail    INDEX     Y   CREATE INDEX "IX_Acounts_Contactemail" ON public."Acounts" USING btree ("Contactemail");
 -   DROP INDEX public."IX_Acounts_Contactemail";
       public            postgres    false    211            n           1259    24616    IX_Incident_AcountaccountName    INDEX     e   CREATE INDEX "IX_Incident_AcountaccountName" ON public."Incident" USING btree ("AcountaccountName");
 3   DROP INDEX public."IX_Incident_AcountaccountName";
       public            postgres    false    212            q           2606    24598 '   Acounts FK_Acounts_Contact_Contactemail    FK CONSTRAINT     ?   ALTER TABLE ONLY public."Acounts"
    ADD CONSTRAINT "FK_Acounts_Contact_Contactemail" FOREIGN KEY ("Contactemail") REFERENCES public."Contact"(email) ON DELETE CASCADE;
 U   ALTER TABLE ONLY public."Acounts" DROP CONSTRAINT "FK_Acounts_Contact_Contactemail";
       public          postgres    false    211    210    3178            r           2606    24610 .   Incident FK_Incident_Acounts_AcountaccountName    FK CONSTRAINT     ?   ALTER TABLE ONLY public."Incident"
    ADD CONSTRAINT "FK_Incident_Acounts_AcountaccountName" FOREIGN KEY ("AcountaccountName") REFERENCES public."Acounts"("accountName");
 \   ALTER TABLE ONLY public."Incident" DROP CONSTRAINT "FK_Incident_Acounts_AcountaccountName";
       public          postgres    false    212    3181    211                   x?????? ? ?      ?   $   x?K?M??1?L?,*.?K?M5??I????b???? ?X
            x?????? ? ?      ?   *   x?32022076405?04????,?L??4?3?3?????? ???     
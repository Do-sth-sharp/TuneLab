﻿using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneLab.GUI;

internal static class Assets
{
    public static SvgIcon Eye = new("<svg width=\"12\" height=\"10\" viewBox=\"0 0 12 10\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M5.99996 1C3.09724 1 0.675952 2.71772 0.119995 4.99993C0.675887 7.2822 3.09721 9 5.99999 9C8.90271 9 11.324 7.28228 11.88 5.00007C11.3241 2.7178 8.90274 1 5.99996 1ZM6 7C7.10457 7 8 6.10457 8 5C8 3.89543 7.10457 3 6 3C4.89543 3 4 3.89543 4 5C4 6.10457 4.89543 7 6 7Z\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon Part = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<rect x=\"0.5\" y=\"3.5\" width=\"23\" height=\"16\" rx=\"1.5\" stroke=\"white\"/>\r\n<path d=\"M0 5C0 3.89543 0.895431 3 2 3H22C23.1046 3 24 3.89543 24 5V7H0V5Z\" fill=\"white\"/>\r\n<rect x=\"3\" y=\"9\" width=\"6\" height=\"2\" fill=\"white\"/>\r\n<rect x=\"9\" y=\"15\" width=\"6\" height=\"2\" fill=\"white\"/>\r\n<rect x=\"15\" y=\"11\" width=\"6\" height=\"2\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon Properties = new("<svg width=\"16\" height=\"16\" viewBox=\"0 0 16 16\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<rect y=\"2\" width=\"16\" height=\"2\" rx=\"1\" fill=\"white\"/>\r\n<rect y=\"7\" width=\"16\" height=\"2\" rx=\"1\" fill=\"white\"/>\r\n<rect y=\"12\" width=\"16\" height=\"2\" rx=\"1\" fill=\"white\"/>\r\n<circle cx=\"12\" cy=\"3\" r=\"2\" fill=\"white\"/>\r\n<circle cx=\"4\" cy=\"8\" r=\"2\" fill=\"white\"/>\r\n<circle cx=\"8\" cy=\"13\" r=\"2\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon Track = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<g clip-path=\"url(#clip0_1327_14013)\">\r\n<path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M11 1C11 0.447716 11.4477 0 12 0C12.5523 0 13 0.447715 13 1V5V9V10V14V15V19V23C13 23.5523 12.5523 24 12 24C11.4477 24 11 23.5523 11 23V19V15V14V10V9V5V1ZM10 5H1C0.447715 5 0 5.44772 0 6V8C0 8.55229 0.447715 9 1 9H10V5ZM10 10H9C8.44771 10 8 10.4477 8 11V13C8 13.5523 8.44771 14 9 14H10V10ZM10 15H6C5.44772 15 5 15.4477 5 16V18C5 18.5523 5.44772 19 6 19H10V15ZM14 19H18C18.5523 19 19 18.5523 19 18V16C19 15.4477 18.5523 15 18 15H14V19ZM14 14H23C23.5523 14 24 13.5523 24 13V11C24 10.4477 23.5523 10 23 10H14V14ZM14 9H15C15.5523 9 16 8.55229 16 8V6C16 5.44772 15.5523 5 15 5H14V9Z\" fill=\"white\"/>\r\n</g>\r\n<defs>\r\n<clipPath id=\"clip0_1327_14013\">\r\n<rect width=\"24\" height=\"24\" fill=\"white\"/>\r\n</clipPath>\r\n</defs>\r\n</svg>");
    public static SvgIcon Gain = new("<svg width=\"16\" height=\"16\" viewBox=\"0 0 16 16\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M14 13V4.41421C14 3.52331 12.9229 3.07714 12.2929 3.70711L3.70711 12.2929C3.07714 12.9229 3.52331 14 4.41421 14H13C13.5523 14 14 13.5523 14 13Z\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon Pan = new("<svg width=\"16\" height=\"16\" viewBox=\"0 0 16 16\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M14 11.17V4.83C14 3.34298 14 2.59947 13.7235 2.30969C13.4948 2.06997 13.1622 1.9591 12.8354 2.01364C12.4403 2.07958 11.9942 2.67439 11.102 3.864L8.7245 7.034C8.46197 7.38404 8.3307 7.55906 8.28133 7.75166C8.23956 7.91459 8.23956 8.08541 8.28133 8.24834C8.3307 8.44094 8.46197 8.61596 8.7245 8.966L11.102 12.136C11.9942 13.3256 12.4403 13.9204 12.8354 13.9864C13.1622 14.0409 13.4948 13.93 13.7235 13.6903C14 13.4005 14 12.657 14 11.17Z\" fill=\"white\"/>\r\n<path d=\"M2 11.17V4.83C2 3.34298 2 2.59947 2.27649 2.30969C2.50521 2.06997 2.83781 1.9591 3.16462 2.01364C3.55968 2.07958 4.00579 2.67439 4.898 3.864L7.2755 7.034C7.53803 7.38404 7.6693 7.55906 7.71867 7.75166C7.76044 7.91459 7.76044 8.08541 7.71867 8.24834C7.6693 8.44094 7.53803 8.61596 7.2755 8.966L4.898 12.136C4.00579 13.3256 3.55968 13.9204 3.16462 13.9864C2.83781 14.0409 2.50521 13.93 2.27649 13.6903C2 13.4005 2 12.657 2 11.17Z\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon Pointer = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M6 19.5V4.5L18 13.5H10.5L6 19.5Z\" stroke=\"white\" stroke-width=\"2\" stroke-linejoin=\"round\"/>\r\n</svg>");
    public static SvgIcon Pitch = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M4 18C4 16 4.5 10 6 10C7.5 10 6.5 14 8 14C9.5 14 9 5 11 5C13 5 11 12 16.5 12C19 12 20 16 20 18\" stroke=\"white\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>\r\n</svg>");
    public static SvgIcon Brush = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<g clip-path=\"url(#clip0_1614_14014)\">\r\n<rect x=\"18.8492\" y=\"4.53564\" width=\"4\" height=\"10\" rx=\"1\" transform=\"rotate(45 18.8492 4.53564)\" fill=\"white\"/>\r\n<path d=\"M5.41417 12.3136C6.8285 12.3136 8.94966 11.6066 10.3639 10.1923L16.0208 15.8491C14.6066 17.2634 12.4853 17.9705 11.071 17.9705L5.41417 12.3136Z\" fill=\"white\" stroke=\"white\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>\r\n</g>\r\n<defs>\r\n<clipPath id=\"clip0_1614_14014\">\r\n<rect width=\"12\" height=\"16\" fill=\"white\" transform=\"translate(15.3137 1) rotate(45)\"/>\r\n</clipPath>\r\n</defs>\r\n</svg>");
    public static SvgIcon WindowClose = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M8 8L16 16\" stroke=\"white\" stroke-linecap=\"round\"/>\r\n<path d=\"M16 8L8 16\" stroke=\"white\" stroke-linecap=\"round\"/>\r\n</svg>");
    public static SvgIcon WindowRestore = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M7.5 16.5V9.5H14.5V16.5H7.5Z\" stroke=\"white\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>\r\n<path d=\"M9.5 9V7.5H16.5V14.5H15\" stroke=\"white\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>\r\n</svg>");
    public static SvgIcon WindowMax = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M7.5 16.5V7.5H16.5V16.5H7.5Z\" stroke=\"white\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>\r\n</svg>");
    public static SvgIcon WindowMin = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M7.5 12H16.5\" stroke=\"white\" stroke-linecap=\"round\"/>\r\n</svg>");
    public static SvgIcon Vibrato = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M3 12C4 11 4.4 6 6 6C8 6 8 18 10 18C12 18 12 6 14 6C16 6 16 18 18 18C20 18 20 13 21 12\" stroke=\"white\" stroke-width=\"2\" stroke-linecap=\"round\"/>\r\n</svg>");
    public static SvgIcon M = new("<svg width=\"8\" height=\"8\" viewBox=\"0 0 8 8\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M0.720625 8V0.128H1.92063L3.43263 4.328C3.52863 4.6 3.62063 4.876 3.70863 5.156C3.80463 5.428 3.90063 5.7 3.99663 5.972H4.04463C4.14063 5.7 4.22863 5.428 4.30863 5.156C4.39663 4.876 4.48863 4.6 4.58463 4.328L6.07263 0.128H7.28463V8H6.34863V3.668C6.34863 3.316 6.36463 2.928 6.39663 2.504C6.42863 2.072 6.45663 1.684 6.48063 1.34H6.43263L5.80862 3.128L4.32063 7.208H3.66063L2.17263 3.128L1.54863 1.34H1.50063C1.52463 1.684 1.54863 2.072 1.57263 2.504C1.60463 2.928 1.62063 3.316 1.62063 3.668V8H0.720625Z\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon S = new("<svg width=\"6\" height=\"10\" viewBox=\"0 0 6 10\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M3.05892 9.144C2.50692 9.144 1.99492 9.04 1.52292 8.832C1.05092 8.616 0.642922 8.332 0.298922 7.98L0.898922 7.284C1.17892 7.58 1.50692 7.82 1.88292 8.004C2.26692 8.18 2.66292 8.268 3.07092 8.268C3.59092 8.268 3.99492 8.152 4.28292 7.92C4.57092 7.68 4.71492 7.368 4.71492 6.984C4.71492 6.712 4.65492 6.496 4.53492 6.336C4.42292 6.176 4.26692 6.04 4.06692 5.928C3.87492 5.816 3.65492 5.704 3.40692 5.592L2.27892 5.1C2.03092 4.996 1.78292 4.86 1.53492 4.692C1.29492 4.524 1.09092 4.308 0.922922 4.044C0.762922 3.78 0.682922 3.456 0.682922 3.072C0.682922 2.672 0.786922 2.316 0.994922 2.004C1.21092 1.684 1.50692 1.436 1.88292 1.26C2.25892 1.076 2.68292 0.983999 3.15492 0.983999C3.62692 0.983999 4.06292 1.076 4.46292 1.26C4.86292 1.436 5.20292 1.668 5.48292 1.956L4.94292 2.604C4.70292 2.372 4.43492 2.192 4.13892 2.064C3.85092 1.928 3.52292 1.86 3.15492 1.86C2.71492 1.86 2.35892 1.964 2.08692 2.172C1.82292 2.38 1.69092 2.66 1.69092 3.012C1.69092 3.26 1.75492 3.468 1.88292 3.636C2.01892 3.796 2.18692 3.928 2.38692 4.032C2.58692 4.136 2.79092 4.232 2.99892 4.32L4.11492 4.8C4.41892 4.928 4.69092 5.084 4.93092 5.268C5.17892 5.444 5.37492 5.664 5.51892 5.928C5.66292 6.184 5.73492 6.508 5.73492 6.9C5.73492 7.316 5.62692 7.696 5.41092 8.04C5.19492 8.376 4.88692 8.644 4.48692 8.844C4.08692 9.044 3.61092 9.144 3.05892 9.144Z\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon CheckBoxFrame = new("<svg width=\"16\" height=\"16\" viewBox=\"0 0 16 16\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<rect x=\"0.5\" y=\"0.5\" width=\"15\" height=\"15\" rx=\"3.5\" stroke=\"white\"/>\r\n</svg>");
    public static SvgIcon Check = new("<svg width=\"16\" height=\"16\" viewBox=\"0 0 16 16\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M3.5 9.5L6 12L12.5 5.5\" stroke=\"white\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>\r\n</svg>");
    public static SvgIcon AutoPage = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<rect x=\"2\" y=\"11\" width=\"16\" height=\"2\" rx=\"1\" fill=\"white\"/>\r\n<rect x=\"18\" y=\"4\" width=\"2\" height=\"16\" rx=\"1\" fill=\"white\"/>\r\n<path d=\"M17 12L13 8\" stroke=\"white\" stroke-width=\"2\" stroke-linecap=\"round\"/>\r\n<path d=\"M17 12L13 16\" stroke=\"white\" stroke-width=\"2\" stroke-linecap=\"round\"/>\r\n</svg>");
    public static SvgIcon Play = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<g clip-path=\"url(#clip0_249_127)\">\r\n<path d=\"M21 10.2679C22.3333 11.0377 22.3333 12.9623 21 13.7321L9 20.6603C7.66667 21.4301 6 20.4678 6 18.9282L6 5.0718C6 3.5322 7.66667 2.56995 9 3.33975L21 10.2679Z\" fill=\"white\"/>\r\n</g>\r\n<defs>\r\n<clipPath id=\"clip0_249_127\">\r\n<rect width=\"24\" height=\"24\" fill=\"white\"/>\r\n</clipPath>\r\n</defs>\r\n</svg>");
    public static SvgIcon Select = new("<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<rect x=\"8\" y=\"4\" width=\"8\" height=\"2\" rx=\"1\" fill=\"white\"/>\r\n<rect x=\"8\" y=\"18\" width=\"8\" height=\"2\" rx=\"1\" fill=\"white\"/>\r\n<rect x=\"11\" y=\"6\" width=\"2\" height=\"12\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon Hyphen = new("<svg width=\"16\" height=\"16\" viewBox=\"0 0 16 16\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<rect x=\"4\" y=\"7\" width=\"8\" height=\"2\" rx=\"1\" fill=\"white\"/>\r\n</svg>");
    public static SvgIcon None = new("");

    public static FontFamily NotoMono = new FontFamily("NotoMono");
}
